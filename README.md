# LINQ Join Example - Author and Book Relationship


This example demonstrates how to use LINQ to join two lists: authors (authors) and books (books), to map books to their respective authors.

Explanation:

*Authors List (authors): Contains information about 3 authors, each with a unique AuthorId.

*Books List (books): Contains 4 books, each associated with an AuthorId, representing the author of the book.

LINQ Query:

*The from clause iterates over the authors list.

*The join clause combines data from the authors and books lists based on the matching AuthorId.

*The resulting data includes the book title (BookName) and the author's name (AuthorName).
