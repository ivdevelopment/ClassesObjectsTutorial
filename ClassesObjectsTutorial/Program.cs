using ClassesObjectsTutorial;

Book book1 = new Book("Harry Potter", "J.K. Rowling", 400);
book1.Afbeelden();

Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
book2.Afbeelden();

Book book3 = new Book();
book3.Afbeelden();

/////////////////////////////////////////////////////////////

Student student1 = new Student("Ian", "Programmeren", 3.6);
student1.Afbeelden();
Student student2 = new Student("Mike", "Architectuur", 3.2);
student2.Afbeelden();

/////////////////////////////////////////////////////////////

Movie movie1 = new Movie("Avengers", "Joss Whedon", "PG-13");
Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");
Movie movie3 = new Movie("The One", "Willy Scottsen", "Dog");
movie1.Afbeelden();
movie2.Afbeelden();
movie3.Afbeelden();

/////////////////////////////////////////////////////////////

Song song1 = new Song("Gin & Juice", "Snoop Dogg", 50000);
Song song2 = new Song("Locked Up", "Akon", 35000);
Song song3 = new Song();
song1.Afbeelden();
song2.Afbeelden();
song3.Afbeelden();