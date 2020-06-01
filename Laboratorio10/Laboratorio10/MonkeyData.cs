using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio10
{
    public static class MonkeyData
    {
        public static IList<Monkey> Monkeys { get; private set; }

        static MonkeyData()
        {
            Monkeys = new List<Monkey>();

            Monkeys.Add(new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Los babuinos son monos africanos y árabes del viejo mundo pertenecientes al género Papio, parte de la subfamilia Cercopithecinae..",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "Los monos capuchinos son monos del Nuevo Mundo de la subfamilia Cebinae. Antes de 2011, la subfamilia contenía un solo género, Cebus.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "El mono azul o mono diademed es una especie de mono del Viejo Mundo nativo de África central y oriental, que abarca desde la cuenca superior del río Congo hasta el este de la grieta africana y del sur hasta el norte de Angola y Zambia",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "Central & South America",
                Details = "Los monos ardilla son los monos del nuevo mundo del género Saimiri. Son el único género en la subfamilia Saimirinae. El nombre del género Saimiri es de origen Tupi, y también fue utilizado como un nombre en inglés por los primeros investigadores.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Details = "El tití león dorado, también conocido como el tití dorado, es un pequeño mono del Nuevo Mundo de la familia Callitrichidae.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Howler Monkey",
                Location = "South America",
                Details = "Los monos aulladores se encuentran entre los monos más grandes del Nuevo Mundo. Quince especies son actualmente reconocidas. Anteriormente clasificados en la familia Cebidae, ahora se colocan en la familia Atelidae.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Japan",
                Details = "El macaco japonés es una especie de mono terrestre del Viejo Mundo originaria de Japón. A veces también se les conoce como el mono de nieve porque viven en áreas donde la nieve cubre el suelo durante meses cada uno.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                Details = "El mandril es un primate de la familia de monos del Viejo Mundo, estrechamente relacionado con los babuinos y aún más estrechamente con el taladro. Se encuentra en el sur de Camerún, Gabón, Guinea Ecuatorial y Congo.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Proboscis Monkey",
                Location = "Borneo",
                Details = "El mono de probóscide o mono de nariz larga, conocido como el bekantan en malayo, es un mono arbóreo marrón rojizo del Viejo Mundo que es endémico de la isla de Borneo, en el sudeste asiático.",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Red-shanked Douc",
                Location = "Vietnam, Laos",
                Details = "La douc con el tallo rojo es una especie de mono del Viejo Mundo, uno de los primates más coloridos. Este mono a veces se llama el \"mono disfrazado\" por su apariencia extravagante. Desde las rodillas hasta los tobillos, luce \"medias \" de color rojo granate, y parece llevar guantes blancos hasta el antebrazo. Su atuendo está acabado con manos y pies negros. La cara dorada está enmarcada por un collar blanco, que es considerablemente más esponjoso en los machos. Los párpados son de un suave polvo azul. La cola es blanca con un triángulo de pelo blanco en la base. Los hombres de todas las edades tienen una mancha blanca en ambos lados de las esquinas del parche de la grupa y genitales rojos y blancos.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gray-shanked Douc",
                Location = "Vietnam",
                Details = "El douc langur de tallo gris es una especie de douc nativa de las provincias vietnamitas de Quảng Nam, Quảng Ngãi, Bình Định, Kon Tum y Gia Lai. La población total se estima en 550 a 700 individuos. En 2016, el Dr. Benjamin Rawson, Director de País de Fauna & Flora International - Programa de Vietnam, anunció el descubrimiento de una población adicional de más de 500 individuos encontrados en el centro de Vietnam, elevando la población total a aproximadamente 1000 individuos.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Snub-nosed Monkey",
                Location = "China",
                Details = "El mono dorado de nariz chata es un mono del Viejo Mundo en la subfamilia Colobinae. Es endémica de un área pequeña en bosques templados y montañosos del centro y suroeste de China. Habitan estos bosques montañosos del suroeste de China a elevaciones de 1,500-3,400 m sobre el nivel del mar. El nombre chino es mono de pelo dorado de Sichuan. También es ampliamente conocido como el mono de nariz chata de Sichuan. De las tres especies de monos de nariz chata en China, el mono dorado de nariz chata es el más ampliamente distribuido en toda China.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Black Snub-nosed Monkey",
                Location = "China",
                Details = "El mono negro de nariz chata, también conocido como el mono de nariz chata de Yunnan, es una especie de primates en peligro de extinción en la familia Cercopithecidae.Es endémico de China, donde los lugareños lo conocen como el mono de pelo dorado de Yunnan y el mono de pelo dorado negro.Está amenazado por la pérdida de hábitat.Fue nombrado después de obispo Félix Biet.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Tonkin Snub-nosed Monkey",
                Location = "Vietnam",
                Details = "El mono de nariz chata de Tonkin o el mono de nariz chata de Dollman es un mono arbóreo del Viejo Mundo de cuerpo delgado, endémico del norte de Vietnam. Es un mono blanco y negro con nariz y labios rosados ​​y manchas azules alrededor de los ojos. Se encuentra en altitudes de 200 a 1,200 m (700 a 3,900 pies) en parches fragmentarios de bosque en áreas escarpadas de piedra caliza. Descrito por primera vez en 1912, el mono fue redescubierto en 1990, pero es extremadamente raro. En 2008, se creía que existían menos de 250 individuos, y la especie fue objeto de un intenso esfuerzo de conservación. La principal amenaza que enfrentan estos monos es la pérdida de hábitat y la caza, y la Unión Internacional para la Conservación de la Naturaleza ha calificado a la especie como \" en peligro de crítico \".",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Thomas's Langur",
                Location = "Indonesia",
                Details = "La langur de Thomas es una especie de primate en la familia Cercopithecidae. Es endémico del norte de Sumatra, Indonesia. Su hábitat natural son los bosques secos tropicales o subtropicales. Está amenazado por la pérdida de hábitat. Sus nombres nativos son reungkah en acehnese y kedih en alas.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Purple-faced Langur",
                Location = "Sri Lanka",
                Details = "El langur de cara púrpura, también conocido como el mono de hoja de cara púrpura, es una especie de mono del Viejo Mundo que es endémica de Sri Lanka. El animal es una especie arbórea de cola larga, identificada por una apariencia principalmente marrón, cara oscura (con la cara inferior más pálida) y una naturaleza muy tímida. La especie fue una vez muy prevalente, encontrada en los suburbios de Colombo y en las aldeas de la \"zona húmeda\" (áreas con altas temperaturas y alta humedad durante todo el año, mientras que los diluvios de lluvia ocurren durante las estaciones del monzón), pero la rápida urbanización ha llevado a una significativa disminución en el nivel de población de los monos.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gelada",
                Location = "Ethiopia",
                Details = "La gelada, a veces llamada mono sangrante o babuino gelada, es una especie de mono del Viejo Mundo que se encuentra solo en las tierras altas de Etiopía, con grandes poblaciones en las montañas Semien. Theropithecus se deriva de las palabras de raíz griega para \"bestia-simio\". Al igual que sus parientes cercanos, los babuinos, es en gran parte terrestre, y pasa gran parte de su tiempo alimentándose en los pastizales.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });
        }
    }
}
