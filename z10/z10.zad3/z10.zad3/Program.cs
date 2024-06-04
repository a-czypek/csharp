using System.Collections;
using z10.zad3;

List<Student> listaStudentow = new List<Student>();

// Dodawanie studentów do listy
listaStudentow.Add(new Student("Adam"));
listaStudentow.Add(new Student("Zofia"));
listaStudentow.Add(new Student("Karol"));

// Sortowanie alfabetyczne listy
listaStudentow.Sort((x, y) => x.nazwa.CompareTo(y.nazwa));

// Wyświetlanie posortowanej listy
foreach (Student student in listaStudentow)
{
    student.Opisz();
}
