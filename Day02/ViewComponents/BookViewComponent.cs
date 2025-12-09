using Day02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Day02.ViewComponents
{
    public class BookViewComponent:ViewComponent
    {
        private Book book = new Book();
        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var b =  book.GetBookList();
            return View(b);
        }
    }
}
