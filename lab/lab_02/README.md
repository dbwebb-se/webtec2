---
revision:
    "2024-10-30": "(B, mos) Calculate stats and points."
    "2024-10-15": "(A, mos) First version."
---
Lab 02: Mer med värden, typer, uttryck, if-satser och loopar 
===========================

I denna laboration får du fortsätta att träna på att programmera med grunderna i programmeringsspråket CSharp med värden, datatyper, uttryck, if-satser och loopar.

Du kan också behöva använda manuelen för att lära dig nya konstruktioner eller leta reda på inbyggda metoder och konstanter.

[[_TOC_]]



Förutsättning
---------------------------

Du har jobbat igenom större delen av lab 01.



Förberedelser
---------------------------

Utför följande steg för att skapa de filer som labben behöver.



### Skapa ett nytt program

Gå till den katalog där du vill jobba och skapa ett nytt projekt så här,

```bash
dotnet new console -o lab_02
```

Projektet skapas i katalogen `lab_02` och du kan flytta ned i den katalogen.

```bash
cd lab_02
```

Verifera att du kan köra koden.

```bash
dotnet run
```



### Hämta filerna till labben

Vi skall hämta ett par filer som behövs för att utföra labben. Utför följande kommandon.

https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab1/lab.js

```bash
wget -OutFile Program.cs https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab_02/Program.cs
wget -OutFile Module.cs https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab_02/Module.cs
wget -OutFile Lab.cs https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab_02/Lab.cs
```

När du är klar kan det se ut så här.

```bash
PS C:\Users\mos\lab_02> dir

    Directory: C:\Users\mos\lab_02

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d-----         10/9/2024   7:35 AM                bin
d-----         10/9/2024   7:35 AM                obj
-a----         10/9/2024   7:35 AM           6860 Lab.cs
-a----         10/9/2024   7:35 AM            252 lab_02.csproj
-a----         10/9/2024   7:35 AM           2992 Module.cs
-a----         10/9/2024   7:37 AM           2341 Program.cs
```



<details>
<summary>PowerShell</summary>

```bash
wget -OutFile Program.cs https://gitlab.com/mikael-roos/programmering1/-/raw/main/lab/lab_02/Program.cs
wget -OutFile Module.cs https://gitlab.com/mikael-roos/programmering1/-/raw/main/lab/lab_02/Module.cs
wget -OutFile Lab.cs https://gitlab.com/mikael-roos/programmering1/-/raw/main/lab/lab_02/Lab.cs
```

När du är klar kan det se ut så här.

```bash
PS C:\Users\mos\lab_02> dir

    Directory: C:\Users\mos\lab_02

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d-----         10/9/2024   7:35 AM                bin
d-----         10/9/2024   7:35 AM                obj
-a----         10/9/2024   7:35 AM           6860 Lab.cs
-a----         10/9/2024   7:35 AM            252 lab_02.csproj
-a----         10/9/2024   7:35 AM           2992 Module.cs
-a----         10/9/2024   7:37 AM           2341 Program.cs
```

</details>

Nu kan du öppna din vscode utifrån denna katalogen.

```
code .
```

Tittar runt i de filerna som finns i labben och försök förstå hur de händer ihop.



Påbörja labben
---------------------------

Börja med att köra labben med `dotnet run`. Det som körs är main-programmet i `Program.cs`.

```bash
$ dotnet run
❌ Hello(), expected: "Hello World!" (String), actual: "" (String)
```

Du kan titta på filen `Program.cs` via vscode och se vad som körs.

I filen `Module.cs` finns alla övningsuppgifter som du skall göra. Det är en metod för varje uppgift och du skall implementera koden inuti metoden så att den returnerar rätt resultat.

I modulen `Lab.cs` finns kod som verifierar att rätt saker returneras från dina metoder i `Module.cs` samt förbereder utskrifter.



Första övningsuppgiften
---------------------------

I den första övningsuppgiften skall du implementera följande funktion.

```csharp
/**
 * Return the string "Hello World!".
 */
public static string Hello()
{
    // TODO: Write your code here.
    return "";
}
```

När du är klar med din implementation så kör du programmet igen och ser om du får grönt ljus som innebär att du gjort rätt.

```bash
$ dotnet run
✅ Hello(), expected: "Hello World!" (String), actual: "Hello World!" (String)
```

Klicka på "Lösningsförslag" nedan för att se hur det kan se ut när du implementerat den första metoden.

<details>
<summary>Lösningsförslag</summary>

```csharp
/**
 * Return the string "Hello World!".
 */
public static string Hello()
{
    // TODO: Write your code here.
    return "Hello World!";
}
```

</details>



Lösning
---------------------------

Denna labben har en lösningsfil som du kan ladda ned och studera. Ibland finns flera olika lösningsförslag till en funktion.

Använd lösningen om du fastnar och inte lyckas ta dig vidare, eller som en studiehjälp för att jämföra dina egna lösningar med lösningar som någon annan har skrivit.

<details>
<summary>Hämta lösningsförslag (Bash)</summary>

```bash
# Stå i katalogen där du har labben
wget -OutFile Solution.cs https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab_02/Solution.cs
```

</details>


<details>
<summary>Hämta lösningsförslag (PowerShell)</summary>

```bash
# Stå i katalogen där du har labben
wget -OutFile Solution.cs https://raw.githubusercontent.com/dbwebb-se/webtec2/refs/heads/main/lab/lab_02/Solution.cs
```

</details>
