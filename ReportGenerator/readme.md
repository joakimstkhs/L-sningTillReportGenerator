# Rapport Generator. 

## Problem beskrivning

Låt oss säga att vi har ett system som hanterar olika typer av rapporter: PDF, Excel och Word. 

Varje rapporttyp har en specifik implementering, 
men i vår lösning behöver vi skapa instanser av dessa rapporter baserat på den typ som skickas in. 

## Lösningsförslag

* Skapa ett gränssnitt (interface) som definierar beteende för vad en report kan göra.

  Genom att använda interfaces kan du skapa en kontraktbaserad design där flera klasser kan dela samma metodsignatur utan att vara direkt relaterade.  
 
```csharp
	public interface IReport
    {
        void Generate();
    }
```

* Skapa en klass för varje typ av report som ärver från IReport

```csharp
public class PdfReport : IReport
{
    public void Generate() => Console.WriteLine("PDF Report Generated.");
}
```

* Skapa en klass som genererar report beroende på typen. 
 
```csharp
public class ReportGenerator
{
    public IReport CreateReport(string reportType)
    {
    :
    }
}
```

## Kända problem

* Dålig utbyggbarhet: Om vi vill lägga till en ny rapporttyp måste vi redigera CreateReport-metoden i ReportGenerator.

* Ökad koppling: ReportGenerator är beroende av de specifika rapportklasserna (PdfReport, ExcelReport, WordReport), vilket gör koden svår att underhålla och testa.

* Hög komplexitet: Koden blir svår att läsa och underhålla när fler rapporttyper läggs till.