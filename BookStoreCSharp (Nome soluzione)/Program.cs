// See https://aka.ms/new-console-template for more information

/* In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
Titolo
Autore
ISBN
Numero pagine
Peso del libro
Larghezza, Altezza e Profondità del libro
Valutazione media
Numero di recensioni
se è disponibile in versione Kindle
se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
*/

string titolo = "Clean Code: A Handbook of Agile Software Craftmanship";
string autore = "Robert C. Martin";
long isbn = 9780132350884;
int numero = 431;
int peso = 800;
double baseLibro = 17.78;
double profonditaLibro = 2.79;
double altezzaLibro = 23.37;
float valutazione = 4.7f;
int numRecensioni = 4571;
bool versioneKindle = true;
bool versioneCopertina = true;

string Kindle = versioneKindle.ToString();
Kindle = "Si";
string copertina = versioneCopertina.ToString();
copertina = "Si";


Console.WriteLine("Titolo: " + titolo);
Console.WriteLine("Autore: " + autore);
Console.WriteLine("Numero di Pagine: " + isbn);
Console.WriteLine("Peso del Libro: " + peso + "g");
Console.WriteLine("Larghezza , Altezza e Profondità del libro: " + baseLibro + " x " + profonditaLibro + " x " + altezzaLibro + " cm");
Console.WriteLine("Valutazione media: " + valutazione + " su 5");
Console.WriteLine("Numero di Recensioni: " + numRecensioni);
Console.WriteLine("E' disponibile nella versione kindle?: " + Kindle);
Console.WriteLine("La copertina è flessibile?: " + copertina);


