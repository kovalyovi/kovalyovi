using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Models;
using System;
using System.Linq;

namespace RazorPagesScripture.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Title = "The Book of Mormon",
                        Book = "1 Nephi",
                        Chapter = 3,
                        verseStart = 7,
                        verseEnd = 7,
                        Notes = "My favorite verse about the power of God",
                        AddedDate = DateTime.Parse("2012-7-22")
                    },

                    new Scripture
                    {
                        Title = "The Book of Mormon",
                        Book = "Jacob",
                        Chapter = 4,
                        verseStart = 4,
                        verseEnd = 6,
                        Notes = "It's a great promise about Prophets!",
                        AddedDate = DateTime.Parse("2013-3-18")
                    },

                    new Scripture
                    {
                        Title = "Old Testament",
                        Book = "Amos",
                        Chapter = 3,
                        verseStart = 7,
                        verseEnd = 7,
                        Notes = "God talks to Prophets to convey His will to the whole planet",
                        AddedDate = DateTime.Parse("2015-8-5")
                    },

                    new Scripture
                    {
                        Title = "New Testament",
                        Book = "James",
                        Chapter = 1,
                        verseStart = 5,
                        verseEnd = 5,
                        Notes = "Joseph Smith had a strong feeling about this verse..",
                        AddedDate = DateTime.Parse("2019-4-15")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}