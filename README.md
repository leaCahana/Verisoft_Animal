חיות


---
תיאור כללי

פרויקט זה מגדיר מערכת אובייקטית לייצוג ומודלינג של בעלי חיים שונים. המטרה היא ליצור מבנה מודולרי ומורחב שיאפשר להוסיף בעלי חיים חדשים בקלות, תוך שמירה על עקביות והפרדת אחריות.

מבנה המערכת
המערכת בנויה סביב המחלקה הבסיסית Animal, אשר מגדירה את המאפיינים והפונקציונליות הכלליים של בעלי החיים:

Animal:

מכיל משתנים מוגנים (protected) כגון mammals, comivorous ו-mood שמייצגים את מאפייני בעל החיים.
מספק נכס CurrentMood שמחזיר את מצב הרוח של בעל החיים באמצעות אינומרציה Lmood.
מגדיר פונקציות כלליות כמו WhatMood(), SayHello() ו-SayHello(int times) שמגדירות את התנהגות בעל החיים.
מספק פונקציות גישה כמו IsMammals(), SetMammals(bool b), Iscomivorous() ו-Setcomivorous(bool b) שמאפשרות לשנות ולקרוא את המאפיינים של בעל החיים.
מגדיר את הפונקציה ToString() שמחזירה את ייצוג המחרוזת של בעל החיים.


Cat, Dog ו-Frog:

מחלקות ירושה של Animal שמגדירות את ההתנהגות הספציפית של כל בעל חיים.
כל מחלקה מכילה משתנה numOfLeghth שמייצג את מספר הרגליים של בעל החיים.
מיישמות את הפונקציות SayHello(), SayHello(int times) ו-WhatMood() באופן ספציפי לכל בעל חיים.
מיישמות את הפונקציה GetNumberLegs() מהממשק ILand שמחזיר את מספר הרגליים של בעל החיים.
בנוסף, Frog מיישמת את הפונקציות hashGills() ו-hashLaysEggs() מהממשק IWater שמייצגות את היכולות המיוחדות של הצפרדע.


Lmood:

איפנומרציה שמייצגת את מצבי הרוח האפשריים של בעלי החיים - MOOD_HAPPY ו-MOOD_SCARED.


ILand ו-IWater:

ממשקים שמגדירים פונקציונליות ספציפית לבעלי חיים יבשתיים ולבעלי חיים מימיים, בהתאמה.
ILand מגדיר פונקציה GetNumberLegs() שמחזירה את מספר הרגליים של בעל החיים.
IWater מגדיר פונקציות hashGills() ו-hashLaysEggs() שמייצגות את היכולות המיוחדות של בעלי חיים מימיים.



יתרונות המערכת

מודולריות וגמישות: המערכת מבוססת על מבנה מודולרי של מחלקות ירושה, מאפשר הוספת בעלי חיים חדשים בקלות, ללא צורך לשנות את הקוד הקיים.
הפרדת אחריות: השימוש במחלקות ירושה ובממשקים מאפשר הפרדה ברורה בין האחריויות והפונקציונליות של כל בעל חיים.
אבטחת גישה: השימוש ברמות הגישה המוגנות (protected) מאפשר לשמור על הפרטים הפנימיים של בעלי החיים ולהגביל את הגישה להם באופן מבוקר.
קריאות קוד ברורות: המבנה המודולרי והשימוש בהורשה והפרדת אחריות מובילים לקוד ברור ונקי, שקל לקרוא ולתחזק.

סיכום
פרויקט זה מספק מערכת מודולרית וגמישה לייצוג ומודלינג של בעלי חיים שונים. באמצעות שימוש בירושה, ממשקים ורמות גישה מוגנות, המערכת מאפשרת הרחבה והוספת בעלי חיים חדשים בקלות, תוך שמירה על עקביות והפרדת אחריות. זה מוביל לקוד קריא, מתוחזק ובעל אבטחת גישה מתאימה


classDiagram
    class Animal {
        #bool mammals
        #bool comivorous
        #int mood
        +Lmood CurrentMood
        +WhatMood()
        +SayHello()
        +SayHello(int times)
        +IsMammals() : Boolean
        +SetMammals(bool b)
        +Iscomivorous() : Boolean  
        +Setcomivorous(bool b)
        +ToString() : string
    }

    class Cat {
        -int numOfLeghth
        +SayHello()
        +SayHello(int times)
        +WhatMood()
        +GetNumberLegs() : int
    }

    class Dog {
        -int numOfLeghth
        +SayHello()
        +SayHello(int times)
        +WhatMood()
        +GetNumberLegs() : int
    }

    class Frog {
        -int numOfLeghth
        +SayHello(int times)
        +WhatMood()
        +GetNumberLegs() : int
        +hashGills() : bool
        +hashLaysEggs() : bool
    }

    <<enum>> Lmood
    Lmood : MOOD_HAPPY
    Lmood : MOOD_SCARED

    Animal <|-- Cat
    Animal <|-- Dog
    Animal <|-- Frog

    ILand <|-- Cat
    ILand <|-- Dog
    ILand <|-- Frog

    IWater <|-- Frog

    interface ILand {
        +GetNumberLegs() : int
    }

    interface IWater {
        +hashGills() : bool
        +hashLaysEggs() : bool
    }


