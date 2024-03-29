using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VOD.Common.DTOModels.Admin;
using VOD.Common.Entities;
using VOD.Common.Extensions;
using VOD.Common.Services;

namespace VOD.Admin.Pages.Courses
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        #region Properties
        private readonly IAdminService _db;
        [BindProperty] public CourseDTO Input { get; set; } = new CourseDTO();
        [TempData] public string Alert { get; set; }

        public SelectList SelectListInstructors { get; set; }
        #endregion

        #region Constructor
        public EditModel(IAdminService db)
        {
            _db = db;
        }
        #endregion

        #region Actions
        public async Task<IActionResult> OnGetAsync(int id)
        {
            try
            {
                Alert = string.Empty;
                //ViewData["Instructors"] = (await _db.GetAsync<Instructor, InstructorDTO>()).ToSelectList("Id", "Name");

                var instructors = (await _db.GetAsync<Instructor, InstructorDTO>());
                SelectListInstructors = new SelectList(instructors, "Id", "Name");


                Input = await _db.SingleAsync<Course, CourseDTO>(s => s.Id.Equals(id));
                return Page();
            }
            catch
            {
                return RedirectToPage("/Index", new { alert = "You do not have access to this page." }); ;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var succeeded = await _db.UpdateAsync<CourseDTO, Course>(Input);
                if (succeeded)
                {
                    // Message sent back to the Index Razor Page.
                    Alert = $"Updated Course: {Input.Title}.";
                    return RedirectToPage("Index");
                }
            }

            // Reload the modules when the page is reloaded
            //ViewData["Instructors"] = (await _db.GetAsync<Instructor, InstructorDTO>()).ToSelectList("Id", "Name");

            var instructors = (await _db.GetAsync<Instructor, InstructorDTO>());
            SelectListInstructors = new SelectList(instructors, "Id", "Name");

            // Something failed, redisplay the form.
            return Page();
        }
        #endregion
    }
}
