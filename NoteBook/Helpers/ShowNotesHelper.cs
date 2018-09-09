using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using NoteBook.Models;

namespace NoteBook.Helpers
{
    public static class ShowNotesHelper
    {
        public static HtmlString ShowNotes(this IHtmlHelper html, IEnumerable<Note> NotesList)
        {
            if (NotesList != null && !NotesList.Any())
            {
                string result = "";
                int count = 0;

                foreach (var note in NotesList)
                {
                    if (count == 0 || count == 3) result += $"<div class='row'>";
                    if (count < 3) result += $"<div class='col-md-4'>" +
                       $"<div class='note' data-toggle='modal' data-target='#test1'>{note.Text}</div></div";
                    if (count >= 3) result += $"<div class='col-md-3'>" +
                       $"<div class='note' data-toggle='modal' data-target='#test1'>{note.Text}</div></div";
                    if (count == 2 || count == 6) result += $"</div>";
                    count++;
                    if (count == 6)
                        count = 0;
                }

                return new HtmlString(result);
            }
            return new HtmlString($"<div class='Nothing'>" +
                $"<h1>There`s nothing here righ now, but we should start somewhere!</h1></div>");
        }
    }
}