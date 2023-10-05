using PetAdoptionApp.Models;

namespace PetAdoptionApp.Static
{
    public class AppData
    {
        private static readonly List<Pet> pets = new()
        {
            new Pet()
            {
                PetID = 23445464,
                PetAge = 1,
                PetDescription = "Upoznajte Bobija, nestašnog šteneta korgija spremnog da se suoči sa svijetom. Bobi nosi hrabar karakter i ima prelijepim bijelim krznom. Osim toga, Bobi će stići kao ljubimac spreman za druženje, dobre naravi i svakodnevno pažljivo tretiran. Posvetili smo se odgajanju ovog malog dragulja i obećavamo vam štene koje potiče od roditelja sa druželjubivim i smirenim karakterom. Ako tražite štence na prodaju u Londonu, obavezno pogledajte ovo šarmantno malo štene. Imamo iskustva u transportu i možemo organizovati sve detalje kako biste sigurno doveli svog šteneta kući, čak i ako niste u Zenici. Ponosni smo i radujemo se podizanju pasa visokog kvaliteta.",
                PetImageSource = "bobi.png",
                PetLocation = "Zenica",
                PetName = "Bobi",
                PetType = new PetType(){ Species = "Pas", Breed = "" },
                ColorHex = "#FF9AA2"
            },
            new Pet()
            {
                PetID = 234235435645,
                PetAge = 4,
                PetDescription = "Upoznajte Lunu, štene dalmatinca spremno za osvajanje svijeta. Luna ima umiljat karakter i nosi predivno brindle krzno. Osim toga, Luna će stići zdrava, prijateljski raspoložena prema djeci i odgojena u obitelji. Posvetili smo se odgajanju ovog malog dragulja i obećavamo vam štene koje potiče od roditelja s hrabrim i pitomim osobinama. Ako tražite štence na prodaju u Travniku, obavezno pogledajte ovo šarmantno malo štene. Imamo iskustva u dostavi i možemo organizirati sve detalje kako biste sigurno doveli svoje štene kući, čak i ako niste već u Travniku. Ponosni smo i radujemo se odgajanju pasa visoke kvalitete.",
                PetImageSource = "luna2.png",
                PetLocation = "Travnik",
                PetName = "Luna",
                PetType = new PetType(){Species = "Pas", Breed = "" },
                ColorHex = "#FFB7B2"
            },
new Pet()
            {
                PetID = 2342547645,
                PetAge = 2,
                PetDescription = "Upoznajte Makija, odanog šteneta zlatnog retrivera spremnog za osvajanje svijeta. Maki ima nježan karakter i nosi prekrasnu bijelu dlaku. Osim toga, Maki će stići zdrav, prijateljski nastrojen prema djeci i odgajan u obitelji. Posvetili smo se odgajanju ovog malog dragulja i obećavamo vam štene koje potječe od roditelja s hrabrim i pitomim osobinama. Ako tražite štence na prodaju u Sarajevu, obavezno pogledajte ovo šarmantno malo štene. Imamo iskustva u dostavi i možemo organizirati sve detalje kako biste sigurno doveli svoje štene kući, čak i ako već niste u Sarajevu. Ponosni smo i sretni što odgajamo pse visoke kvalitete.",
                PetImageSource = "maki.png",
                PetLocation = "Sarajevo",
                PetName = "Maki",
                PetType = new PetType(){Species = "Pas", Breed = "" },
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetID = 56475879,
                PetAge = 8,
                PetDescription = "Upoznajte Astora, haskija koji je spreman za osvajanje svijeta. Astor ima samouvjeren karakter i nosi prekrasnu smeđu dlaku. Osim toga, Astor će stići svakodnevno tretiran, prijateljski nastrojen prema djeci i prijateljski nastrojen prema mačkama. Posvetili smo se podizanju ovog malog dragulja i obećavamo vam štene koje potječe od roditelja s šarmantnim i pametnim osobinama. Ako tražite štence na prodaju u Doboju, obavezno pogledajte ovo šarmantno malo štene. Imamo iskustva u dostavi i možemo organizirati sve detalje kako biste sigurno doveli svoje štene kući, čak i ako već niste u Doboju. Ponosni smo i sretni što odgajamo pse visoke kvalitete.",
                PetImageSource = "astor.png",
                PetLocation = "Doboj",
                PetName = "Astor",
                PetType = new PetType(){ Species = "Pas", Breed = ""},
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetID = 98780978,
                PetAge = 5,
                PetDescription = "Upoznajte Artura, kratkodlaka mačka sa sivim krznom i žutim očima očima, veoma razigrana i društvena mačka.",
                PetImageSource = "artur.png",
                PetLocation = "Tuzla",
                PetName = "Artur",
                PetType = new PetType(){ Species = "Macka", Breed = ""},
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetID = 1231234543,
                PetAge = 1,
                PetDescription = "Upoznajte Lili, mačak srednje duge dlake, šarolike boje s bijelim pramenom, dvobojnim očima u boji jantara i zelene, te kovrčavim repom.",
                PetImageSource = "lili.png",
                PetLocation = "Zenica",
                PetName = "Lili",
                PetType = new PetType(){Species = "Macka", Breed = "" },
                ColorHex = "#C7CEEA"
            },
new Pet()
            {
                PetID = 21576867,
                PetAge = 1,
                PetDescription = "Upoznajte Obia, malu macu sa mekanom i dugom dlakom, bijele boje, zelenim očima, te debelog repa",
                PetImageSource = "obi.png",
                PetLocation = "Sarajevo",
                PetName = "Obi",
                PetType = new PetType(){Species = "Macka", Breed = "" },
                ColorHex = "#B5EAD7"
            },
new Pet()
            {
                PetID = 32432423423,
                PetAge = 7,
                PetDescription = "Upoznajte Cicka, dugodlaka siva mačka s dvobojnim zelenim i smeđim očima, s velikim ušima. Veoma lijepa i elegantna mačka",
                PetImageSource = "cicko.png",
                PetLocation = "Banja Luka",
                PetName = "Cicko",
                PetType = new PetType(){Species = "Macka", Breed = "" },
                ColorHex = "#E2F0CB"
            },
new Pet()
            {
                PetID = 123432,
                PetAge = 11,
                PetDescription = "",
                PetImageSource = "marli.png",
                PetLocation = "Jajce",
                PetName = "Marli",
                PetType = new PetType(){Species = "Zec", Breed = "" },
                ColorHex = "#FFDAC1"
            },
new Pet()
            {
                PetID = 1231445,
                PetAge = 3,
                PetDescription = "",
                PetImageSource = "teo.png",
                PetLocation = "Zenica",
                PetName = "Teo",
                PetType = new PetType(){Species = "Zec", Breed = "" },
                ColorHex = "#FFB7B2"
            },
new Pet()
            {
                PetID = 220389,
                PetAge = 8,
                PetDescription = "",
                PetImageSource = "pako.png",
                PetLocation = "Mostar",
                PetName = "Pako",
                PetType = new PetType(){Species = "Zec", Breed = "" },
                ColorHex = "#FF9AA2"
            },
new Pet()
            {
                PetID = 23423425,
                PetAge = 6,
                PetDescription = "",
                PetImageSource = "kapone1.png",
                PetLocation = "Sarajevo",
                PetName = "Kapone",
                PetType = new PetType(){Species = "Zec", Breed = "" },
                ColorHex = "FFB7B2"
            } };
        public static List<Pet> Pets = pets;
    }
}