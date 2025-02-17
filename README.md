# Diary
## Popis projektu
Tento projekt obsahuje třídu `Zaznam`, která slouží k ukládání a správě záznamů v deníku. Každý záznam obsahuje datum a text, přičemž záznamy jsou uchovávány v obousměrně propojeném seznamu (`LinkedList`). Uživatel může přidávat, mazat, navigovat mezi záznamy a zobrazovat jejich obsah.
Projekt je implementován v jazyce **C# 13.0** a cílí na framework **.NET 9.0**.
### Klíčové funkce
- **Přidávání záznamů**: Možnost přidat nový záznam pomocí metody `PridejZaznam`.
- **Mazání záznamů**: Odstranění aktuálního záznamu pomocí metody `VymazZaznam`.
- **Navigace mezi záznamy**: Metody `DalsiZaznam` a `PredchoziZaznam` umožňují pohyb mezi záznamy.
- **Zobrazení aktuálního záznamu**: Tisk informace o aktuálním záznamu na konzoli prostřednictvím metody `ZobrazAktualniZaznam`.

## Použití
Projekt je vytvořený jako cvičení Kolecke a Linq na webu IT Network. 
## Struktura třídy `Zaznam`
### Vlastnosti
- `Datum`: Datum záznamu.
- `Text`: Obsah textového záznamu.
- `Node`: Ukazatel na aktuální uzel seznamu záznamů.
- `Zaznamy`: Propojený seznam (LinkedList) všech záznamů.

### Metody
1. **`PridejZaznam(DateTime datum, string text)`**
    - Přidá nový záznam do propojeného seznamu.
    - Nastaví první záznam jako aktuální, pokud seznam dosud neobsahuje žádné záznamy.

2. **`VymazZaznam()`**
    - Odstraní aktuální záznam.
    - Automaticky nastaví předchozí nebo následující záznam jako aktuální.

3. **`DalsiZaznam()`**
    - Posune ukazatel na další záznam v seznamu (pokud existuje).
    - Vypíše data a text dalšího záznamu na konzoli.

4. **`PredchoziZaznam()`**
    - Posune ukazatel na předchozí záznam v seznamu (pokud existuje).
    - Vypíše data a text předchozího záznamu na konzoli.
    - Vypíše chybovou zprávu, pokud předchozí záznam neexistuje.

5. **`ZobrazAktualniZaznam()`**
    - Vypíše datum a text aktuálního záznamu.
    - Pokud seznam neobsahuje žádné záznamy, akce se neprovede.
