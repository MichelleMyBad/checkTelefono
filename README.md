# checkTelefono
Esercizio C# in console che permette di trovare il numero di cellulare italiano in un array di numeri.

# Svolgimento
Per prima cosa bisognerà creare un <i>for</i> che scorra l'array contenente i diversi numeri di telefono e assegnare il numero da controllare ad una variabile.

```c#
public static string Check(string[] input)
{
  string numero="";
  for(int i=0; i<input.Length; i++ ){   
      numero=input[i];
```

<br>
Continuiamo facendo un controllo su lunghezza e inizio del nostro numero di telefono: in caso il numero inizi per <b>0039</b> o <b>+39</b>, dovremo controllare che, dopo i prefissi citati, siano presenti altri 10 numeri, primo dei quali dovrà essere un <b>3</b>. Un altro caso accettabile lo troviamo se il numero è semplicemente lungo 10 e inizi per <b>3</b>.

```c#
if((numero.Length==14&&numero.Substring(0,5)=="00393")||(numero.Length==10&&numero[0]=='3')||(numero.Length==13&&numero.Substring(0,4)=="+393"))
```
N.B. È importante controllare prima la lunghezza e poi l'inizio del numero per velocizzare il controllo.
<br><br>
Successivamente creiamo una funzione che, tramite ciclo <i>for</i>, controlli se il numero di cellulare ricevuto contiene o meno dei caratteri non numerici, in caso tali caratteri venghano rilevati, la nostra funzione ritornerà <i>false</i>, di modo da poter segnalare di scartare il numero.

```c#
public static bool CheckClean(string numero){
for(int i=1; i<numero.Length; i++ )
    if(char.IsDigit(numero[i])==false)
        return false;

return true;
}
```
<br>
Utilizziamo questa funzione per fare un ulteriore controllo.

```c#
if((numero.Length==14&&numero.Substring(0,5)=="00393")||(numero.Length==10&&numero[0]=='3')||(numero.Length==13&&numero.Substring(0,4)=="+393"))
    if(CheckClean(input[i]))
```

<br>
Ritorniamo infine, in caso siano stati superati tutti i controlli, il numero di cellulare corretto, altrimenti ritorniamo una stringa vuola, per segnalare che non sono stati trovati numeri validi all'interno dell'array.

```c#
                return input[i];        
    }
    return "";
}
```
