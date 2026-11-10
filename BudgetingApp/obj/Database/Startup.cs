using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

using var context = new AppDbContext();

// CREATE: Adding a new record to the database
var newUser = new User { Username = "Matt Horton", Password = Sha256("MyPass") };
context.Users.Add(newUser);
context.SaveChanges(); // Persists changes into the DB 

// READ: Querying the database using standard LINQ extension methods
var firstUser = context.Users
                        .Where(p => p.Username = "Matt Horton")
                        .ToList();