---
revision:
    "2024-10-03": "(B, mos) Removed css-file and dapted for bash."
    "2024-10-01": "(A, mos) First version."
---
Programmera grunderna i JavaScript
===========================

I denna övningen får du träna på att programmera med grunderna i programmeringsspråket JavaScript med siffor boolean, strängar och arrayer samt loopar och if-satser.

[[_TOC_]]

<!--
TODO

* rensa bort arrayer

* fixa så att if, if else , else täcks av uppgifterna

* fixa så att while och do-while täcks av uppgifterna

* string
    * replaceSpaces
    * capitalizeWords
    * countCharacter (vilket tecken förekommer mest)
    * säkerställ att string-övningarna underlättar att förbereda för hangman
-->


Förutsättning
---------------------------

Du kan grunderna i hur JavaScript samverkar med en webbsida och du kan grundkonstruktioner för villkor och iterationer i språket.

Du är medveten om hur du kan söka fram ny kunskap via manualen MDN.



Förberedelser
---------------------------

Förbered dig så här för övningen. Börja att öppna din terminal och gå till den katalog där du vill börja jobba.

Skapa nu en katalog för `lab1`.

```
mkdir lab1
cd lab1
```

Nu skall vi hämta tre filer från nätet som behövs för att komma igång med labben. Exekvera följande kommandon i terminalen.

```
wget -O lab.html https://gitlab.com/mikael-roos/webbutveckling2/-/raw/main/public/example/js/lab1/lab.html
wget -O main.js https://gitlab.com/mikael-roos/webbutveckling2/-/raw/main/public/example/js/lab1/main.js
wget -O module.js https://gitlab.com/mikael-roos/webbutveckling2/-/raw/main/public/example/js/lab1/module.js
```

När du är klar kan det se ut så här.

```
PS C:\Users\mos\webbutveckling2\lab1> ls


    Directory: C:\Users\mos\webbutveckling2\lab1


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a----         10/2/2024   1:38 PM           1826 main.js
-a----         10/2/2024   1:38 PM           4028 module.js
-a----         10/2/2024   1:38 PM            385 page.html
-a----         10/2/2024   1:38 PM            149 style.css
```

Nu kan du öppna din vscode utifrån denna katalogen.

```
code .
```

Tittar runt i de fyla filerna som finns i labben och försök förstå hur de händer ihop. 

Öppna webbsidan `page.html` i din webbläsare via LiveServer.

Öppna din dev tools och fliken console. Här kan du exekvera hela labben och du får status utskriven.

Det kan se ut så här.

![Labben i devtools](img/lab.png)

I filen `module.js` finns alla övningsuppgifter som du skall utföra i form av funktioner som skall implementeras. Varje gång du implementerar en funktion så kan du ladda om webbsidan för att se om det blir grönt eller rött.

Det som visas i devtools console är utskriften från `main.js` och det är tester som körs mot de funktioner som du skall implementera.



Första övningsuppgiften
---------------------------

I den första övningsuppgiften skall du implementera följande funktion.

```js
/**
 * Returns the string "Hello world".
 *
 * @returns {string} A welcome message "Hello world".
 */
export function hello () {
    // TODO: Write your code here.
}
```

När du är klar med din implementation så kan du ladda om din webbsida och se om det blev grönt.

<details>
<summary>Lösningsförslag</summary>

```js
/**
 * Returns the string "Hello world".
 *
 * @returns {string} A welcome message "Hello world".
 */
export function hello () {
    // TODO: Write your code here.
    return "Hello world";
}
```

</details>



Provkör en funktion i devtools
---------------------------

Ibland vill man provköra sina egna funktioner i devtools. Du kan göra det på detta viset.

Importera modulen så den blir tillgänglig i devtools console.

```js
const module = await import('./module.js')
```

Nu har du den tillgänglig och kan anropa en metod som ligger i modulen.

```js
module.hello()
```

Nu kan du implementera funktionerna, samtidigt som du kan testköra dem.
