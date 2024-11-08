using Diary.Data;
using Diary.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers;

public class DiaryEntriesController(ApplicationDbContext dbContext) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        List<DiaryEntry> objDiaryEntryList = dbContext.DiaryEntries.ToList();
        return View(objDiaryEntryList);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DiaryEntry objDiaryEntry)
    {
        // Server side validation
        if (objDiaryEntry.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 characters long");
        }

        if (ModelState.IsValid)
        {
            dbContext.DiaryEntries.Add(objDiaryEntry); // Adds the new record
            dbContext.SaveChanges(); // Saves the new record
            return RedirectToAction("Index");
        }

        return View(objDiaryEntry);
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        DiaryEntry? entry = dbContext.DiaryEntries.Find(id);
        if (entry == null)
        {
            return NotFound();
        }

        return View(entry);
    }

    [HttpPost]
    public IActionResult Edit(DiaryEntry objDiaryEntry)
    {
        if (objDiaryEntry.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 characters long");
        }

        if (ModelState.IsValid)
        {
            dbContext.DiaryEntries.Update(objDiaryEntry); // Updates the new record
            dbContext.SaveChanges(); // Saves the new record
            return RedirectToAction("Index");
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        DiaryEntry? entry = dbContext.DiaryEntries.Find(id);
        if (entry == null)
        {
            return NotFound();
        }

        return View(entry);
    }

    [HttpPost]
    public IActionResult Delete(DiaryEntry objDiaryEntry)
    {
        dbContext.DiaryEntries.Remove(objDiaryEntry); // Removes the new record
        dbContext.SaveChanges(); // Saves the new record
        return RedirectToAction("Index");
    }
}