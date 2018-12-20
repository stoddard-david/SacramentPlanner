using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly SacramentPlannerContext _context;

        public MeetingsController(SacramentPlannerContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meeting.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                                        .FirstOrDefaultAsync(m => m.ID == id);

            Descriptions.meetingSpeakers = (from s in _context.Speaker where meeting.ID == s.MeetingID select s).ToList();

            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Conducting,OpeningHymn,Invocation,SacramentHymn,ClosingHymn,Benediction")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        public async Task<IActionResult> AddSpeaker([Bind("Name,Topic,MeetingID")] Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speaker);
        }

        public void ShowSpeakers(int id)
        {
            //meetingSpeakers = from s in _context.Meeting where id = select s;

            //SpeakerList.meetingSpeakers = (from s in _context.Meeting select s.Speakers).ToList();

        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Conducting,OpeningHymn,Invocation,SacramentHymn,ClosingHymn,Benediction")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

    // GET: Speakers/Edit/5
    public async Task<IActionResult> EditSpeaker(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var speaker = await _context.Speaker.FindAsync(id);
      if (speaker == null)
      {
        return NotFound();
      }
      return View(speaker);
    }

    // POST: Speakers/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditSpeaker(int id, [Bind("ID,Name,Topic,MeetingID")] Speaker speaker)
    {
      if (id != speaker.ID)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(speaker);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!SpeakerExists(speaker.ID))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(Index));
      }
      return View(speaker);
    }

    // GET: Meetings/Delete/5
    public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meeting.FindAsync(id);
            _context.Meeting.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meeting.Any(e => e.ID == id);
        }


    // GET: Speaker/Delete/5
    public async Task<IActionResult> DeleteSpeaker(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var speaker = await _context.Speaker
          .FirstOrDefaultAsync(m => m.ID == id);
      if (speaker == null)
      {
        return NotFound();
      }

      return View(speaker);
    }

    // POST: Speaker/Delete/5
    [HttpPost, ActionName("DeleteSpeaker")]
    [ValidateAntiForgeryToken]
    public async void DeleteSpeakerConfirmed(int id, int meetingID)
    {
      var speaker = await _context.Speaker.FindAsync(id);
      _context.Speaker.Remove(speaker);
      await _context.SaveChangesAsync();
      Response.Redirect("/Meetings/Details/" + meetingID);
      //return RedirectToAction(nameof(Index));
    }

    private bool SpeakerExists(int id)
    {
      return _context.Speaker.Any(e => e.ID == id);
    }
  }
}
