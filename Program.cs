using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics_Session02
{
 

                class Program
                    {
                        static string[] books =
                        {
                        "Clean Code",
                        "The Pragmatic Programmer",
                        "Refactoring"
                    };

                        static void Main()
                        {
                            #region Question 1

                            // 1. Declare a string title = "clean code".
                            // Call ToUpper() and store it in upperTitle.
                            // Print both variables to show that title did not change.

                            {
                                string title = "clean code";
                                string upperTitle = title.ToUpper();

                                Console.WriteLine(title);
                                Console.WriteLine(upperTitle);
                            }

                            #endregion


                            #region Question 2

                            // 2. Declare two separate string variables with the same literal.
                            // Use ReferenceEquals() to check if they point to the same object.

                            {
                                string book1 = "Clean Code";
                                string book2 = "Clean Code";

                                Console.WriteLine(object.ReferenceEquals(book1, book2));
                            }

                            #endregion


                            #region Question 3

                            // 3. Create a StringBuilder, Append "Book List",
                            // then Append " - Updated" onto the same object.

                            StringBuilder sb = new StringBuilder();

                            sb.Append("Book List");
                            sb.Append(" - Updated");

                            Console.WriteLine(sb);

                            #endregion


                            #region Question 4

                            // 4. Using the same StringBuilder,
                            // Replace "Book List" with "Library".

                            sb.Replace("Book List", "Library");

                            Console.WriteLine(sb);

                            #endregion


                            #region Question 5

                            // 5. Build the sentence using the + operator.

                            {
                                string title = "Clean Code";
                                int pages = 464;

                                string sentence = "Book: " + title + ", Pages: " + pages;

                                Console.WriteLine(sentence);
                            }

                            #endregion


                            #region Question 6

                            // 6. Build the same sentence using string interpolation.

                            {
                                string title = "Clean Code";
                                int pages = 464;

                                string sentence = $"Book: {title}, Pages: {pages}";

                                Console.WriteLine(sentence);
                            }

                            #endregion


                            #region Question 7

                            // 7. Build the same sentence using string.Format().

                            {
                                string title = "Clean Code";
                                int pages = 464;

                                string sentence = string.Format(
                                    "Book: {0}, Pages: {1}", title, pages);

                                Console.WriteLine(sentence);
                            }

                            #endregion


                            #region Question 8

                            // 8. Use if / else to print Long Book if pages > 300,
                            // otherwise print Short Book.

                            {
                                int pages = 464;

                                if (pages > 300)
                                {
                                    Console.WriteLine("Long Book");
                                }
                                else
                                {
                                    Console.WriteLine("Short Book");
                                }
                            }

                            #endregion


                            #region Question 9

                            // 9. Print the message only if pages > 300
                            // and isAvailable is true. Use && operator.

                            {
                                int pages = 464;
                                bool isAvailable = true;

                                if (pages > 300 && isAvailable == true)
                                {
                                    Console.WriteLine("You can borrow this book");
                                }
                            }

                            #endregion


                            #region Question 10

                            // 10. Use switch to check the book title
                            // and print the appropriate message.

                            {
                                string title = "Refactoring";

                                switch (title)
                                {
                                    case "Clean Code":
                                        Console.WriteLine("Great choice!");
                                        break;

                                    case "Refactoring":
                                        Console.WriteLine("Nice pick!");
                                        break;

                                    default:
                                        Console.WriteLine("Never heard of it");
                                        break;
                                }
                            }

                            #endregion


                            #region Question 11

                            // 11. Use the ternary operator to store
                            // Long Book or Short Book in sizeLabel.

                            {
                                int pages = 464;

                                string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

                                Console.WriteLine(sizeLabel);
                            }

                            #endregion


                            #region Question 12

                            // 12. Using the books array, use a for loop
                            // to print each book with its position number.

                            for (int i = 0; i < books.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {books[i]}");
                            }

                            #endregion


                            #region Question 13

                            // 13. Using the same books array,
                            // use a while loop to print every book title.

                            {
                                int i = 0;

                                while (i < books.Length)
                                {
                                    Console.WriteLine(books[i]);
                                    i++;
                                }
                            }

                            #endregion


                            #region Question 14

                            // 14. Write a do-while loop that prints
                            // "Checking book..." exactly 3 times.

                            {
                                int i = 0;

                                do
                                {
                                    Console.WriteLine("Checking book...");
                                    i++;

                                } while (i < 3);
                            }

                            #endregion


                            #region Question 15

                            // 15. Using the same books array,
                            // use foreach to print every book title.

                            foreach (string book in books)
                            {
                                Console.WriteLine(book);
                            }

                            #endregion


                            #region Question 16

                            // 16. Print each title, but stop completely
                            // once you reach "Refactoring" using break.

                            foreach (string book in books)
                            {
                                if (book == "Refactoring")
                                {
                                    break;
                                }

                                Console.WriteLine(book);
                            }

                            #endregion


                            #region Question 17

                            // 17. Print every title except
                            // "The Pragmatic Programmer" using continue.

                            foreach (string book in books)
                            {
                                if (book == "The Pragmatic Programmer")
                                {
                                    continue;
                                }

                                Console.WriteLine(book);
                            }

                            #endregion


                            #region Question 18

                            // 18. Write PrintFirstBook() method.
                            // If the array is empty, use return to exit early.

                            PrintFirstBook();

                            #endregion
                        }


                        #region Question 18 - Method

                        static void PrintFirstBook()
                        {
                            if (books.Length == 0)
                            {
                                return;
                            }

                            Console.WriteLine(books[0]);
                        }

                        #endregion
                    }

                }

