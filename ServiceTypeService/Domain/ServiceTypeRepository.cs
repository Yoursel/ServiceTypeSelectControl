using System.Collections.Generic;

namespace ServiceTypeService.Domain
{
    public class ServiceTypeRepository
    {
        public static List<ServiceType> ServiceTypes
        {
            get
            {
                return new List<ServiceType>()
                {
                    new ServiceType {Id = 1118027, Code = "18027", Name = "Рентгенография пальцев руки"},
                    new ServiceType
                    {
                        Id = 1118029,
                        Code = "18029",
                        Name = "Рентгенография тазобедренного сустава (2 проекции)"
                    },
                    new ServiceType {Id = 1118034, Code = "18034", Name = "Рентгенография придаточных пазух носа"},
                    new ServiceType
                    {
                        Id = 1118036,
                        Code = "18036",
                        Name = "Рентгенография турецкого седла (прицельно), орбит"
                    },
                    new ServiceType {Id = 1118046, Code = "18046", Name = "Рентгенографические исследования: Гортань"},
                    new ServiceType {Id = 1118047, Code = "18047", Name = "Рентгенография сердца, диафрагмы"},
                    new ServiceType {Id = 1118049, Code = "18049", Name = "Рентгенография костей таза"},
                    new ServiceType {Id = 1118052, Code = "18052", Name = "Маммография прицельная с увеличением"},
                    new ServiceType
                    {
                        Id = 1118055,
                        Code = "18055",
                        Name = "Рентгенография височных костей (сравнительно): по Шюллеру"
                    },
                    new ServiceType
                    {
                        Id = 1118057,
                        Code = "18057",
                        Name = "Рентгенография височных костей (сравнительно): по Стеньверсу"
                    },
                    new ServiceType {Id = 1118061, Code = "18061", Name = "Томография  средостения"},
                    new ServiceType {Id = 1118063, Code = "18063", Name = "Рентгенография  слюнных  протоков"},
                    new ServiceType {Id = 1118065, Code = "18065", Name = "Фистулография"},
                    new ServiceType {Id = 1118072, Code = "18072", Name = "Флюорография легких (одна проекция)"},
                    new ServiceType
                    {
                        Id = 1118077,
                        Code = "18077",
                        Name = "Флюорография костей и суставов в двух проекциях"
                    },
                    new ServiceType
                    {
                        Id = 1118114,
                        Code = "18114",
                        Name = "МСКТ ангиография брюшного отдела аорты с болюсным контрастированием"
                    },
                    new ServiceType {Id = 1118116, Code = "18116", Name = "МСКТ зубочелюстной области"},
                    new ServiceType {Id = 1118122, Code = "18122", Name = "Количественная КТ остеоденситометрия"},
                    new ServiceType {Id = 1118124, Code = "18124", Name = "МСКТ орбит"},
                    new ServiceType {Id = 1119003, Code = "19003", Name = "Вытяжение  (1 сеанс)"},
                    new ServiceType {Id = 1119007, Code = "19007", Name = "Ионофорез кожи"},
                    new ServiceType {Id = 1119010, Code = "19010", Name = "Амплипульстерапия"},
                    new ServiceType {Id = 1119015, Code = "19015", Name = "Дарсонвализация полостная"},
                    new ServiceType {Id = 1119019, Code = "19019", Name = "Магнитофорез"},
                    new ServiceType {Id = 1119023, Code = "19023", Name = "КВЧ-терапия"},
                    new ServiceType
                    {
                        Id = 1119030,
                        Code = "19030",
                        Name = "УЗ-терапия в сочетании с интерференциальной терапией"
                    },
                    new ServiceType {Id = 1119033, Code = "19033", Name = "Лазерная терапия на аппарате ВЕАМ 904"},
                    new ServiceType {Id = 1119034, Code = "19034", Name = "Лазерная терапия на аппарате УЗОР-2К"},
                    new ServiceType {Id = 1120002, Code = "20002", Name = "Гипербарическая оксигенация"},
                    new ServiceType {Id = 1121003, Code = "21003", Name = "Покрытие одного зуба фтор-лаком"},
                    new ServiceType {Id = 1121004, Code = "21004", Name = "Снятие зубных отложений с 1 зуба"},
                    new ServiceType {Id = 1121009, Code = "21009", Name = "Лечение  кариеса"},
                    new ServiceType
                    {
                        Id = 1121011,
                        Code = "21011",
                        Name = "Лечение пульпита однокорневого зуба в один прием"
                    },
                    new ServiceType
                    {
                        Id = 1121012,
                        Code = "21012",
                        Name = "Лечение пульпита многокорневого зуба в один прием"
                    },
                    new ServiceType {Id = 1121040, Code = "21040", Name = "Снятие и анализ окклюдограммы"},
                    new ServiceType {Id = 1121048, Code = "21048", Name = "Вестибулопластика"},
                    new ServiceType
                    {
                        Id = 1121050,
                        Code = "21050",
                        Name = "Временное шинирование при болезнях пародонта (один зуб)"
                    },
                    new ServiceType {Id = 1111075, Code = "11075", Name = "Ультразвуковое исследование простаты с ЦДК"},
                    new ServiceType
                    {
                        Id = 1111078,
                        Code = "11078",
                        Name = "Ультразвуковое исследование щитовидной железы"
                    },
                    new ServiceType
                    {
                        Id = 1111079,
                        Code = "11079",
                        Name =
                            "Ультразвуковое исследование щитовидной железы с исследованием сосудов и кровотока объемных образований"
                    },
                    new ServiceType {Id = 1123084, Code = "23084", Name = "Стеклоиономерный цемент"},
                    new ServiceType {Id = 1123093, Code = "23093", Name = "Снятие искусственной коронки штампованной"},
                    new ServiceType
                    {
                        Id = 1123103,
                        Code = "23103",
                        Name = "Съемные протезы пластмассовые: Зуб один (частиный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123109,
                        Code = "23109",
                        Name = "Съемные протезы пластмассовые: Зуб семь (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1111085,
                        Code = "11085",
                        Name = "Ультразвуковое исследование мягких тканей (одна зона)"
                    },
                    new ServiceType
                    {
                        Id = 1111087,
                        Code = "11087",
                        Name = "Ультразвуковое исследование симметричных групп поверхностно расположенных лимфоузлов"
                    },
                    new ServiceType
                    {
                        Id = 1111088,
                        Code = "11088",
                        Name =
                            "Ультразвуковое исследование симметричных групп поверхностно расположенных лимфоузлов с ЦДК"
                    },
                    new ServiceType {Id = 1111090, Code = "11090", Name = "Ультразвуковое исследование почек"},
                    new ServiceType {Id = 1111091, Code = "11091", Name = "Ультразвуковое исследование надпочечников"},
                    new ServiceType {Id = 1111092, Code = "11092", Name = "Ультразвуковое исследование печени"},
                    new ServiceType
                    {
                        Id = 1111093,
                        Code = "11093",
                        Name = "Ультразвуковое исследование поджелудочной железы"
                    },
                    new ServiceType
                    {
                        Id = 1111097,
                        Code = "11097",
                        Name = "Дуплексное сканирование артерий матки и пуповины плода"
                    },
                    new ServiceType
                    {
                        Id = 1111105,
                        Code = "11105",
                        Name = "Ультразвуковое исследование жидкости в брюшной полости"
                    },
                    new ServiceType
                    {
                        Id = 1112040,
                        Code = "12040",
                        Name = "Внутрисуставное введение лекарственных средств (без стоимости препарата)"
                    },
                    new ServiceType
                    {
                        Id = 1112043,
                        Code = "12043",
                        Name = "Введение лекарственных препаратов периартикулярно (без стоимости препарата)"
                    },
                    new ServiceType
                    {
                        Id = 1112047,
                        Code = "12047",
                        Name = "Вскрытие кожного панариция, атеромы, абсцесса, фурункула"
                    },
                    new ServiceType
                    {
                        Id = 1112056,
                        Code = "12056",
                        Name = "Лечение заболеваний прямой кишки лазерным скальпелем"
                    },
                    new ServiceType
                    {
                        Id = 1112058,
                        Code = "12058",
                        Name = "Оперативное вмешательство при заворотах, выворотах век"
                    },
                    new ServiceType {Id = 1112062, Code = "12062", Name = "Фиброректосигмоскопия"},
                    new ServiceType {Id = 1112063, Code = "12063", Name = "Левосторонняя фиброколоноскопия"},
                    new ServiceType {Id = 1112067, Code = "12067", Name = "Удаление птеригиума"},
                    new ServiceType {Id = 1112071, Code = "12071", Name = "Профилактика столбняка"},
                    new ServiceType {Id = 1112079, Code = "12079", Name = "Лечение заболеваний прямой кишки аппаратом "},
                    new ServiceType {Id = 1116027, Code = "16027", Name = "Онкоцитологический мазок"},
                    new ServiceType {Id = 1116030, Code = "16030", Name = "Микроальбумин мочи"},
                    new ServiceType {Id = 1116032, Code = "16032", Name = "Альбумин"},
                    new ServiceType {Id = 1116035, Code = "16035", Name = "Остаточный азот"},
                    new ServiceType {Id = 1116039, Code = "16039", Name = "Гликозилированный гемоглобин"},
                    new ServiceType {Id = 1116040, Code = "16040", Name = "Сиаловые кислоты"},
                    new ServiceType {Id = 1116041, Code = "16041", Name = "Серомукоид"},
                    new ServiceType {Id = 1116048, Code = "16048", Name = "Альфа-холестерин"},
                    new ServiceType {Id = 1116051, Code = "16051", Name = "Билирубин (прямой)"},
                    new ServiceType {Id = 1116058, Code = "16058", Name = "АЛТ"},
                    new ServiceType {Id = 1116062, Code = "16062", Name = "ГГТ"},
                    new ServiceType {Id = 1116065, Code = "16065", Name = "АЧТВ"},
                    new ServiceType {Id = 1116067, Code = "16067", Name = "Фибриноген"},
                    new ServiceType {Id = 1116072, Code = "16072", Name = "Определение группы крови"},
                    new ServiceType {Id = 1116080, Code = "16080", Name = "Исследование на микрофлору (количественно)"},
                    new ServiceType {Id = 1116081, Code = "16081", Name = "Исследование на бруцеллез"},
                    new ServiceType {Id = 1116087, Code = "16087", Name = "РПГА с эритроцитарным диагностикумом"},
                    new ServiceType
                    {
                        Id = 1116105,
                        Code = "16105",
                        Name = "Анализ крови на сифилис методом ИФА (из вены, без стоимости взятия крови)"
                    },
                    new ServiceType {Id = 1116121, Code = "16121", Name = "Андростендион"},
                    new ServiceType {Id = 1116123, Code = "16123", Name = "Лютеинизирующий гормон (ЛГ)"},
                    new ServiceType {Id = 1116128, Code = "16128", Name = "Свободный бета-ХГЧ"},
                    new ServiceType {Id = 1116133, Code = "16133", Name = "Антитела к тиреоглобуллину"},
                    new ServiceType {Id = 1116145, Code = "16145", Name = "СА 125"},
                    new ServiceType {Id = 1118078, Code = "18078", Name = "Радиовизиография зубов"},
                    new ServiceType {Id = 1118082, Code = "18082", Name = "Срочное описание флюорографии легких"},
                    new ServiceType {Id = 1118084, Code = "18084", Name = "Распечатка ортопантограммы"},
                    new ServiceType {Id = 1118086, Code = "18086", Name = "Рентгеноскопия толстого кишечника досмотром"},
                    new ServiceType {Id = 1118087, Code = "18087", Name = "Рентгеноскопия инородных тел"},
                    new ServiceType {Id = 1118093, Code = "18093", Name = "МСКТ придаточных пазух носа"},
                    new ServiceType
                    {
                        Id = 1110004,
                        Code = "10004",
                        Name = "Прием (осмотр, консультация) врача-специалиста высшей категории"
                    },
                    new ServiceType
                    {
                        Id = 1110006,
                        Code = "10006",
                        Name = "Прием (осмотр, консультация) врача-специалиста первой категории"
                    },
                    new ServiceType
                    {
                        Id = 1110010,
                        Code = "10010",
                        Name = "Приём (осмотр, консультация) врача-специалиста без категории"
                    },
                    new ServiceType {Id = 1110014, Code = "10014", Name = "Консультативный прием"},
                    new ServiceType
                    {
                        Id = 1111002,
                        Code = "11002",
                        Name = "Школа для больных с сердечной недостаточностью"
                    },
                    new ServiceType {Id = 1111004, Code = "11004", Name = "Школа для больных с  ожирением"},
                    new ServiceType {Id = 1111009, Code = "11009", Name = "Реовазография"},
                    new ServiceType
                    {
                        Id = 1111019,
                        Code = "11019",
                        Name = "Внутримышечное введение лекарственных средств"
                    },
                    new ServiceType {Id = 1111022, Code = "11022", Name = "Инстилляции медикаментов, ванночки"},
                    new ServiceType {Id = 1111032, Code = "11032", Name = "Подбор очков (сложный)"},
                    new ServiceType {Id = 1111053, Code = "11053", Name = "Эхокардиография"},
                    new ServiceType {Id = 1111057, Code = "11057", Name = "Дуплексное сканирование почечных артерий"},
                    new ServiceType
                    {
                        Id = 1111067,
                        Code = "11067",
                        Name = "Ультразвуковое исследование матки и придатков"
                    },
                    new ServiceType
                    {
                        Id = 1111069,
                        Code = "11069",
                        Name = "Ультразвуковое исследование матки и придатков с ЦДК сосудов"
                    },
                    new ServiceType {Id = 1116148, Code = "16148", Name = "РЭА"},
                    new ServiceType {Id = 1116151, Code = "16151", Name = "HBs-ag"},
                    new ServiceType {Id = 1116152, Code = "16152", Name = "IgG к вирусу краснухи"},
                    new ServiceType {Id = 1116153, Code = "16153", Name = "IgG к вирусу герпеса"},
                    new ServiceType {Id = 1116154, Code = "16154", Name = "IgG к токсоплазме"},
                    new ServiceType {Id = 1116155, Code = "16155", Name = "IgG к цитомегаловирусу"},
                    new ServiceType {Id = 1116156, Code = "16156", Name = "IgМ к вирусу краснухи"},
                    new ServiceType {Id = 1116157, Code = "16157", Name = "IgМ к токсоплазме"},
                    new ServiceType {Id = 1116160, Code = "16160", Name = "Эритропоэтин"},
                    new ServiceType {Id = 1116162, Code = "16162", Name = "Интерлейкин 10"},
                    new ServiceType {Id = 1116163, Code = "16163", Name = "Интерлейкин 2R"},
                    new ServiceType {Id = 1116165, Code = "16165", Name = "Интерлейкин 8"},
                    new ServiceType {Id = 1116167, Code = "16167", Name = "Гомоцистеин"},
                    new ServiceType {Id = 1116168, Code = "16168", Name = "Креатинкиназа МВ"},
                    new ServiceType {Id = 1116169, Code = "16169", Name = "Инсулин"},
                    new ServiceType {Id = 1116173, Code = "16173", Name = "СТГ"},
                    new ServiceType {Id = 1116176, Code = "16176", Name = "Маркер резорбции костей"},
                    new ServiceType {Id = 1116181, Code = "16181", Name = "Хламидии (Ch. Trachomatis) IgG"},
                    new ServiceType {Id = 1118003, Code = "18003", Name = "Рентгеноскопия пищевода"},
                    new ServiceType {Id = 1111137, Code = "11137", Name = "Ультразвуковая верификация пола плода"},
                    new ServiceType
                    {
                        Id = 1111139,
                        Code = "11139",
                        Name =
                            "Ультразвуковое исследование матки и придатков     с применением абдоминального и трансвагинального датчиков"
                    },
                    new ServiceType {Id = 1112003, Code = "12003", Name = "Первичная хирургическая обработка раны"},
                    new ServiceType
                    {
                        Id = 1112005,
                        Code = "12005",
                        Name = "Удаление доброкачественных новообразований кожи   и подкожной клетчатки"
                    },
                    new ServiceType
                    {
                        Id = 1112013,
                        Code = "12013",
                        Name =
                            "Удаление доброкачественных новообразований кожи и слизистых оболочек лазерным скальпелем размером 1 мм."
                    },
                    new ServiceType {Id = 1112015, Code = "12015", Name = "Биопсия пункционная тонкоигольная"},
                    new ServiceType {Id = 1112023, Code = "12023", Name = "Иссечение новообразования молочной железы"},
                    new ServiceType
                    {
                        Id = 1112030,
                        Code = "12030",
                        Name = "Гипсования при переломах костей (гипс большой)"
                    },
                    new ServiceType
                    {
                        Id = 1112032,
                        Code = "12032",
                        Name = "Лечение гемороя на приборе IRC повторный курс (один узел)"
                    },
                    new ServiceType {Id = 1112033, Code = "12033", Name = "Перевязка в гнойной перевязочной"},
                    new ServiceType {Id = 1206343, Code = "18129", Name = "Рентгенография легких (2 проекции)"},
                    new ServiceType {Id = 1118005, Code = "18005", Name = "Рентгеноскопия желудка и 12-перстной кишки"},
                    new ServiceType {Id = 1118007, Code = "18007", Name = "Ирригоскопия"},
                    new ServiceType
                    {
                        Id = 1118008,
                        Code = "18008",
                        Name = "Рентгенография поясничного отдела позвоночника"
                    },
                    new ServiceType
                    {
                        Id = 1118010,
                        Code = "18010",
                        Name = "Рентгенография шейного отдела позвоночника           ( 2 проекции)"
                    },
                    new ServiceType {Id = 1118014, Code = "18014", Name = "Рентгенография лопатки (2 проекции)"},
                    new ServiceType {Id = 1118015, Code = "18015", Name = "Рентгенография крестца и копчика"},
                    new ServiceType {Id = 1118017, Code = "18017", Name = "Рентгенография костей голени (2 проекции)"},
                    new ServiceType {Id = 1118020, Code = "18020", Name = "Рентгенография костей стопы сравнительно"},
                    new ServiceType {Id = 1206159, Code = "", Name = "Эндокринолог"},
                    new ServiceType {Id = 1206160, Code = "", Name = "Лабораторные исследования (эндокринолог)"},
                    new ServiceType {Id = 1117098, Code = "17098", Name = "РНК вируса гепатита С, качественный"},
                    new ServiceType {Id = 1117107, Code = "17107", Name = "РНК гепатита В п/количественный (Амплисенс)"},
                    new ServiceType
                    {
                        Id = 1118125,
                        Code = "18125",
                        Name = "МСКТ с в/в контрастированием (без стоимости контрастного вещества)"
                    },
                    new ServiceType {Id = 1206219, Code = "", Name = "Процедурный кабинет"},
                    new ServiceType {Id = 1206259, Code = "", Name = "Лабораторные исследования (медосмотр)"},
                    new ServiceType {Id = 1206299, Code = "16183", Name = "Определение Jg G к Hbс - антигену"},
                    new ServiceType {Id = 1206301, Code = "16185", Name = "Исследование антител на H.pilori"},
                    new ServiceType {Id = 1206303, Code = "16187", Name = "Определение гастрина"},
                    new ServiceType
                    {
                        Id = 1206305,
                        Code = "16189",
                        Name = "Исследование уровня общего магния в сыворотке крови"
                    },
                    new ServiceType {Id = 1206308, Code = "16192", Name = "Исследование глюкозы в моче"},
                    new ServiceType
                    {
                        Id = 1206309,
                        Code = "16193",
                        Name =
                            "Микроскопическое исследование отпечатков с поверхности перианальных складок на яйца остриц"
                    },
                    new ServiceType {Id = 1206311, Code = "18127", Name = "Рентгенография стопы (2 проекции)"},
                    new ServiceType
                    {
                        Id = 1206315,
                        Code = "11158",
                        Name = "Дуплексное сканирование артерий нижней  конечности"
                    },
                    new ServiceType {Id = 1206316, Code = "11159", Name = "Ультразвуковое исследование желчного пузыря"},
                    new ServiceType {Id = 1206345, Code = "18131", Name = "Маммография"},
                    new ServiceType
                    {
                        Id = 1206348,
                        Code = "22060",
                        Name = "Операция удаления постоянного зуба под инъекционной анестезией"
                    },
                    new ServiceType
                    {
                        Id = 1206349,
                        Code = "22061",
                        Name =
                            "Медикаментозная обработка раневой поверхности после вскрытия абсцесса, фурункула, некрт., повязка в челюстно-лицевой области"
                    },
                    new ServiceType {Id = 1206351, Code = "25070", Name = "Профилактический прием в смотровом кабинете"},
                    new ServiceType
                    {
                        Id = 1206352,
                        Code = "25071",
                        Name = "Профилактический прием (осмотр, консультация) врача-инфекциониста"
                    },
                    new ServiceType
                    {
                        Id = 1206353,
                        Code = "25072",
                        Name = "Профилактический прием (осмотр, консультация) врача-уролога"
                    },
                    new ServiceType {Id = 1121041, Code = "21041", Name = "Сошлифовка эмали со ската бугра одного зуба"},
                    new ServiceType
                    {
                        Id = 1206355,
                        Code = "25074",
                        Name = "Профилактический прием (осмотр, консультация) врача-ревматолога"
                    },
                    new ServiceType {Id = 1116017, Code = "16017", Name = "Уробилин мочи"},
                    new ServiceType {Id = 1116019, Code = "16019", Name = "Суточная потеря белка"},
                    new ServiceType {Id = 1116021, Code = "16021", Name = "Копрограмма"},
                    new ServiceType {Id = 1116022, Code = "16022", Name = "Кал на скрытую кровь"},
                    new ServiceType {Id = 1116024, Code = "16024", Name = "Мазок на хламидии"},
                    new ServiceType {Id = 1116025, Code = "16025", Name = "Мокрота на кислоустойчивые бактерии"},
                    new ServiceType {Id = 1116034, Code = "16034", Name = "Мочевина"},
                    new ServiceType {Id = 1116036, Code = "16036", Name = "Креатинин"},
                    new ServiceType {Id = 1116037, Code = "16037", Name = "Глюкоза"},
                    new ServiceType
                    {
                        Id = 1116038,
                        Code = "16038",
                        Name = "Определение глюкозы крови (обследование на дому)"
                    },
                    new ServiceType {Id = 1116042, Code = "16042", Name = "С-реактивный белок"},
                    new ServiceType {Id = 1116043, Code = "16043", Name = "Ревматоидный фактор"},
                    new ServiceType {Id = 1116044, Code = "16044", Name = "Коагулограмма"},
                    new ServiceType {Id = 1116050, Code = "16050", Name = "Билирубин (общ.)"},
                    new ServiceType {Id = 1116052, Code = "16052", Name = "Хлор"},
                    new ServiceType {Id = 1116053, Code = "16053", Name = "Железо"},
                    new ServiceType {Id = 1116054, Code = "16054", Name = "ОЖСС"},
                    new ServiceType {Id = 1116056, Code = "16056", Name = "Кальций (общ.)"},
                    new ServiceType {Id = 1116057, Code = "16057", Name = "АСТ"},
                    new ServiceType {Id = 1116060, Code = "16060", Name = "Липаза"},
                    new ServiceType {Id = 1116061, Code = "16061", Name = "Щелочная фосфатаза"},
                    new ServiceType {Id = 1116064, Code = "16064", Name = "Определение активности КФК"},
                    new ServiceType {Id = 1116066, Code = "16066", Name = "ПТИ"},
                    new ServiceType {Id = 1116068, Code = "16068", Name = "РФМК"},
                    new ServiceType {Id = 1116073, Code = "16073", Name = "Определение резус-фактора"},
                    new ServiceType {Id = 1116075, Code = "16075", Name = "Исследование на кишечный дисбактериоз"},
                    new ServiceType {Id = 1116077, Code = "16077", Name = "Исследование на возбудителей дизентерии"},
                    new ServiceType {Id = 1116078, Code = "16078", Name = "Исследование на сальмонеллы"},
                    new ServiceType {Id = 1116083, Code = "16083", Name = "Исследование на возбудителей коклюша"},
                    new ServiceType {Id = 1116085, Code = "16085", Name = "Серологическое исследование"},
                    new ServiceType {Id = 1116086, Code = "16086", Name = "Кал на условно-патогенную микрофлору (УПМ)"},
                    new ServiceType {Id = 1116090, Code = "16090", Name = "Исследование на трихомонады"},
                    new ServiceType {Id = 1113002, Code = "13002", Name = "Сбор секрета простаты"},
                    new ServiceType {Id = 1113003, Code = "13003", Name = "Инстилляция мочевого пузыря"},
                    new ServiceType {Id = 1113005, Code = "13005", Name = "Цистоскопия"},
                    new ServiceType {Id = 1113007, Code = "13007", Name = "Диатермоэлектроэксцизия полипа  уретры"},
                    new ServiceType {Id = 1115025, Code = "15025", Name = "Прием врача гинеколога - эндокринолога"},
                    new ServiceType {Id = 1116001, Code = "16001", Name = "Общий полный крови"},
                    new ServiceType {Id = 1116002, Code = "16002", Name = "Общий анализ крови (обследование на дому)"},
                    new ServiceType {Id = 1116003, Code = "16003", Name = "Подсчет лейкоцитарной формулы"},
                    new ServiceType {Id = 1116004, Code = "16004", Name = "Аппаратный анализ крови"},
                    new ServiceType {Id = 1116008, Code = "16008", Name = "Ретикулоциты"},
                    new ServiceType {Id = 1116009, Code = "16009", Name = "Длительность кровотечения"},
                    new ServiceType {Id = 1116010, Code = "16010", Name = "Время свертывания крови"},
                    new ServiceType {Id = 1116012, Code = "16012", Name = "Мазок из носа на лейкоцитограмму"},
                    new ServiceType {Id = 1116014, Code = "16014", Name = "Анализ по Нечипоренко"},
                    new ServiceType {Id = 1116015, Code = "16015", Name = "Анализ мочи по Зимницкому"},
                    new ServiceType {Id = 1116016, Code = "16016", Name = "Желчные пигменты мочи"},
                    new ServiceType {Id = 1116018, Code = "16018", Name = "Анализ мочи на трихомонады"},
                    new ServiceType {Id = 1116023, Code = "16023", Name = "Мазок на Gn"},
                    new ServiceType
                    {
                        Id = 1122007,
                        Code = "22007",
                        Name =
                            "Сложное удаление зуба с выкраиванием слизисто надкостничного лоскута  с отечественным анестетиком"
                    },
                    new ServiceType
                    {
                        Id = 1122012,
                        Code = "22012",
                        Name = "Внутриротовой разрез с дренированием раны с отечественным анестетиком"
                    },
                    new ServiceType
                    {
                        Id = 1122017,
                        Code = "22017",
                        Name = "Операция резекция верхушки корня двух и более зубов"
                    },
                    new ServiceType
                    {
                        Id = 1122024,
                        Code = "22024",
                        Name = "Удаление доброкачественного образования кости"
                    },
                    new ServiceType {Id = 1122029, Code = "22029", Name = "Шинирование при вывихе зуба"},
                    new ServiceType
                    {
                        Id = 1122038,
                        Code = "22038",
                        Name = "Наложение косметического шва (одного) на лице при травме мягких тканей"
                    },
                    new ServiceType
                    {
                        Id = 1122048,
                        Code = "22048",
                        Name =
                            "Вскрытие абсцесса челюстно-лицевой области наружным путем (разрезание, медикаментозная обработка, дренаж, повязка)"
                    },
                    new ServiceType
                    {
                        Id = 1122050,
                        Code = "22050",
                        Name =
                            "Медикаментозная обработка и перевязка после вскрытия воспалительного очага в челюстно-лицевой области"
                    },
                    new ServiceType {Id = 1122055, Code = "22055", Name = "Бужирование протоков слюнных желез"},
                    new ServiceType {Id = 1123010, Code = "23010", Name = "Коронка телескопическая"},
                    new ServiceType {Id = 1123013, Code = "23013", Name = "Зуб пластмассовый"},
                    new ServiceType {Id = 1123021, Code = "23021", Name = "Реставрация фасетки фотополимером"},
                    new ServiceType {Id = 1123032, Code = "23032", Name = "Гипс"},
                    new ServiceType {Id = 1123035, Code = "23035", Name = "Эластик, стомальгин, упен"},
                    new ServiceType {Id = 1116502, Code = "16502", Name = "Гемоглобин"},
                    new ServiceType {Id = 1116503, Code = "16503", Name = "Лейкоциты"},
                    new ServiceType {Id = 1116508, Code = "16508", Name = "Тромбоциты"},
                    new ServiceType {Id = 1116509, Code = "16509", Name = "Базофилы (Б)"},
                    new ServiceType {Id = 1116510, Code = "16510", Name = "Эозинофилы (Э)"},
                    new ServiceType {Id = 1116513, Code = "16513", Name = "Палочкоядерные (П)"},
                    new ServiceType {Id = 1116514, Code = "16514", Name = "Сегментоядерные (С)"},
                    new ServiceType {Id = 1116517, Code = "16517", Name = "СОЭ"},
                    new ServiceType {Id = 1116601, Code = "16601", Name = "Цвет"},
                    new ServiceType {Id = 1116602, Code = "16602", Name = "Реакция (pH)"},
                    new ServiceType {Id = 1116603, Code = "16603", Name = "Прозрачность"},
                    new ServiceType {Id = 1116607, Code = "16607", Name = "Сахар"},
                    new ServiceType {Id = 1116608, Code = "16608", Name = "Лейкоциты"},
                    new ServiceType {Id = 1116612, Code = "16612", Name = "Эпителий"},
                    new ServiceType {Id = 1116615, Code = "16615", Name = "Соли"},
                    new ServiceType {Id = 1116871, Code = "16871", Name = "Мазок из уха"},
                    new ServiceType {Id = 1116872, Code = "16872", Name = "Рана"},
                    new ServiceType {Id = 1116873, Code = "16873", Name = "Глаз"},
                    new ServiceType {Id = 1116876, Code = "16876", Name = "С-канал"},
                    new ServiceType {Id = 1116877, Code = "16877", Name = "Сперма"},
                    new ServiceType {Id = 1116882, Code = "16882", Name = "Моча"},
                    new ServiceType {Id = 1116884, Code = "16884", Name = "Кал"},
                    new ServiceType {Id = 1116706, Code = "16706", Name = "Трихомонус"},
                    new ServiceType {Id = 1116491, Code = "16491", Name = "МНО"},
                    new ServiceType {Id = 1202094, Code = "", Name = "Все услуги"},
                    new ServiceType {Id = 1202022, Code = "", Name = "Исследование мочи"},
                    new ServiceType {Id = 1202023, Code = "", Name = "Исследование кала"},
                    new ServiceType {Id = 1204013, Code = "", Name = "Меркеры анемии"},
                    new ServiceType {Id = 1204014, Code = "", Name = "Гепатиты"},
                    new ServiceType {Id = 1204017, Code = "", Name = "Урологические онкомаркеры"},
                    new ServiceType {Id = 1202002, Code = "", Name = "Прочие лаб. исследования"},
                    new ServiceType {Id = 1202096, Code = "", Name = "Приемы врачей"},
                    new ServiceType {Id = 1203012, Code = "", Name = "УЗДГ"},
                    new ServiceType {Id = 1203019, Code = "", Name = "Прочие терапевтические услуги"},
                    new ServiceType {Id = 1203040, Code = "", Name = "R-исследования"},
                    new ServiceType {Id = 1203042, Code = "", Name = "Урография"},
                    new ServiceType {Id = 1203050, Code = "", Name = "Лучевые исследования"},
                    new ServiceType {Id = 1204060, Code = "", Name = "Медосмотры"},
                    new ServiceType {Id = 1205013, Code = "", Name = "Флюорисследования (невролог)"},
                    new ServiceType {Id = 1205020, Code = "", Name = "Кардиолог"},
                    new ServiceType {Id = 1206000, Code = "", Name = "Медосмотры"},
                    new ServiceType {Id = 1206115, Code = "", Name = "Форма 086 У"},
                    new ServiceType {Id = 1206139, Code = "", Name = "Бассейн"},
                    new ServiceType {Id = 1125035, Code = "25035", Name = "Онкоцитологический мазок"},
                    new ServiceType {Id = 1118096, Code = "18096", Name = "МСКТ грудного отдела позвоночника"},
                    new ServiceType {Id = 1118098, Code = "18098", Name = "МСКТ костей или суставов"},
                    new ServiceType {Id = 1118104, Code = "18104", Name = "Повторное описание снимка МСКТ"},
                    new ServiceType
                    {
                        Id = 1118106,
                        Code = "18106",
                        Name = "МСКТ головного мозга с болюсным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1118107,
                        Code = "18107",
                        Name = "МСКТ органов грудной полости с болюсным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1118108,
                        Code = "18108",
                        Name = "МСКТ органов брюшной полости с болюсным контрастированием"
                    },
                    new ServiceType {Id = 1123083, Code = "23083", Name = "Временная фиксация"},
                    new ServiceType {Id = 1123085, Code = "23085", Name = "Коррекция протеза"},
                    new ServiceType {Id = 1123087, Code = "23087", Name = "Эластическая подкладка"},
                    new ServiceType {Id = 1123094, Code = "23094", Name = "Изготовление культевой вкладки в один канал"},
                    new ServiceType {Id = 1123096, Code = "23096", Name = "Изготовление культевой вкладки в три канала"},
                    new ServiceType {Id = 1206317, Code = "11160", Name = "Рефлексотерапия (1 процедура)"},
                    new ServiceType
                    {
                        Id = 1206318,
                        Code = "11150",
                        Name = "Импульсно-волновая допплерография сосудов шеи и головы"
                    },
                    new ServiceType
                    {
                        Id = 1206319,
                        Code = "11151",
                        Name =
                            "Ультразвуковая допплерография ветвей брюшного отдела аорты (чревного ствола, печеночной, селезеночной, верхней брыжеечной, почечных артерий)"
                    },
                    new ServiceType {Id = 1206324, Code = "11156", Name = "Допплерография сердца и сосудов плода"},
                    new ServiceType
                    {
                        Id = 1206325,
                        Code = "12081",
                        Name = "Анестезиологическое пособие (внутривенный наркоз)"
                    },
                    new ServiceType {Id = 1206326, Code = "13010", Name = "Замена цистостомы"},
                    new ServiceType
                    {
                        Id = 1206327,
                        Code = "14034",
                        Name = "Биопсия новообразований на ЛОР органах (без стоимости гистологии)"
                    },
                    new ServiceType
                    {
                        Id = 1206328,
                        Code = "14035",
                        Name = "Зондирование пазух носа через естественные соустья"
                    },
                    new ServiceType {Id = 1206329, Code = "15030", Name = "Биопсия"},
                    new ServiceType
                    {
                        Id = 1206330,
                        Code = "16194",
                        Name = "Микроскопическое исследование влагалищных мазков"
                    },
                    new ServiceType
                    {
                        Id = 1206332,
                        Code = "16196",
                        Name = "Анализ крови на сифилис методом ИФА (из вены, без стоимости взятия крови)"
                    },
                    new ServiceType {Id = 1206333, Code = "16108", Name = "Реакция Вассермана (RW) микрометод"},
                    new ServiceType
                    {
                        Id = 1206336,
                        Code = "16112",
                        Name = "Исследование уровня липопротеидов низкой плотности"
                    },
                    new ServiceType
                    {
                        Id = 1206338,
                        Code = "16113",
                        Name = "Исследование ревматоидных факторов (количественно)"
                    },
                    new ServiceType {Id = 1206339, Code = "16114", Name = "Определение иммуноглобулинов A"},
                    new ServiceType {Id = 1206340, Code = "16115", Name = "Определение иммуноглобулинов M"},
                    new ServiceType {Id = 1206341, Code = "16116", Name = "Определение иммуноглобулинов G"},
                    new ServiceType
                    {
                        Id = 1123099,
                        Code = "23099",
                        Name = "Фарфор и металлокерамика: Зуб металлокерамический (коронка)"
                    },
                    new ServiceType
                    {
                        Id = 1123104,
                        Code = "23104",
                        Name = "Съемные протезы пластмассовые: Зуб два (частичный ,съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123105,
                        Code = "23105",
                        Name = "Съемные протезы пластмассовые: Зуб три (частичный ,съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123108,
                        Code = "23108",
                        Name = "Съемные протезы пластмассовые: Зуб шесть (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1206480,
                        Code = "23144",
                        Name = "Протезирование цельнолитными коронками из КХС на имплантатах"
                    },
                    new ServiceType {Id = 1206481, Code = "22062", Name = "Операция-имплантация"},
                    new ServiceType {Id = 1206484, Code = "22065", Name = "Установка абатмента"},
                    new ServiceType
                    {
                        Id = 1206500,
                        Code = "18133",
                        Name = "Введение контрастного вещества для внутривенного контрастирования"
                    },
                    new ServiceType
                    {
                        Id = 1123114,
                        Code = "23114",
                        Name = "Съемные протезы пластмассовые: Зуб двенадцать (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123115,
                        Code = "23115",
                        Name = "Съемные протезы пластмассовые: Зуб тринадцать (частичный. съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123120,
                        Code = "23120",
                        Name = "Прием (осмотр, консультация) врача стоматолога-ортопеда"
                    },
                    new ServiceType
                    {
                        Id = 1123132,
                        Code = "23132",
                        Name = "Стальные фасетки и литки. - Нержавеющая сталь (Россия)"
                    },
                    new ServiceType
                    {
                        Id = 1123136,
                        Code = "23136",
                        Name =
                            "Аттачмен - Никель хромовый сплав <МЕАИоу> (Италия) для металлокерамики, цельнолитых коронок и мостов."
                    },
                    new ServiceType
                    {
                        Id = 1124004,
                        Code = "24004",
                        Name =
                            "Лечение больного в дневном стационаре включая стоимость лекарственных средств (хирургический  профиль)"
                    },
                    new ServiceType
                    {
                        Id = 1124006,
                        Code = "24006",
                        Name =
                            "Лечение больного в дневном стационаре в палате повышенной комфортности (без учета стоимости лекарств и услуг других подразделений поликлиники)"
                    },
                    new ServiceType
                    {
                        Id = 1125008,
                        Code = "25008",
                        Name = "Профилактический прием (осмотр, консультация) врача-стоматолога"
                    },
                    new ServiceType
                    {
                        Id = 1125016,
                        Code = "25016",
                        Name = "Медицинский осмотр с оформлением других справок  (женщины)"
                    },
                    new ServiceType {Id = 1125020, Code = "25020", Name = "Взятие материала на бакпосев"},
                    new ServiceType {Id = 1125027, Code = "25027", Name = "Взятие крови из периферической вены"},
                    new ServiceType
                    {
                        Id = 1125028,
                        Code = "25028",
                        Name = "Общий (клинический) анализ крови развернутый (с лейкоформулой)"
                    },
                    new ServiceType {Id = 1125032, Code = "25032", Name = "Исследование уровня глюкозы в крови"},
                    new ServiceType {Id = 1125033, Code = "25033", Name = "Исследование уровня ретикулоцитов в крови"},
                    new ServiceType {Id = 1125036, Code = "25036", Name = "Исследование кала на яйца глистов"},
                    new ServiceType {Id = 1125042, Code = "25042", Name = "Реакция Вассермана (RW) микрометод"},
                    new ServiceType
                    {
                        Id = 1125043,
                        Code = "25043",
                        Name = "Исследование уровня аланин-трансаминазы в крови"
                    },
                    new ServiceType {Id = 1125054, Code = "25054", Name = "Мазок на Gn"},
                    new ServiceType {Id = 1125059, Code = "25059", Name = "УЗИ молочных желез"},
                    new ServiceType {Id = 1206116, Code = "", Name = "Санаторно-курортная карта"},
                    new ServiceType {Id = 1206119, Code = "25805", Name = "Прием врача-офтальмолога"},
                    new ServiceType
                    {
                        Id = 1123130,
                        Code = "23130",
                        Name =
                            "Металлокерамика Цельнолитые - Никель хромовый сплав <МЕАИоу> (Италия) для металлокерамики, цельнолитых коронок и мостов."
                    },
                    new ServiceType
                    {
                        Id = 1123134,
                        Code = "23134",
                        Name =
                            "Бюгель - Кобальт хромовый сплав для бюгелей и комбинированных работ. <UGIN DENTAIRE> (Франция)"
                    },
                    new ServiceType
                    {
                        Id = 1123137,
                        Code = "23137",
                        Name = "Кламмер - Кобальт хромовый сплав. <UGIN DENTAIRE> (Франция)"
                    },
                    new ServiceType
                    {
                        Id = 1123140,
                        Code = "23140",
                        Name =
                            "Литой базис (без дублирующей модели) - Кобальть хромовый сплав. <UGIN DENTAIRE> (Франция)"
                    },
                    new ServiceType {Id = 1206419, Code = "10000", Name = "Явка на прием"},
                    new ServiceType {Id = 1206439, Code = "11162", Name = "Рассечение слезных точек"},
                    new ServiceType {Id = 1116182, Code = "16182", Name = "Хламидии (Ch. trachomatis) IgА"},
                    new ServiceType {Id = 1115029, Code = "15029", Name = "Медикаментозное прерывание беременности"},
                    new ServiceType {Id = 1118002, Code = "18002", Name = "Рентгеноскопия брюшной полости прицельно"},
                    new ServiceType
                    {
                        Id = 1118009,
                        Code = "18009",
                        Name = "Рентгенография грудного отдела позвоночника            (2 проекции)"
                    },
                    new ServiceType {Id = 1118011, Code = "18011", Name = "Рентгенография черепа, в одной проекции"},
                    new ServiceType {Id = 1118018, Code = "18018", Name = "Рентгенография костей плеча (2 проекции)"},
                    new ServiceType {Id = 1118023, Code = "18023", Name = "Рентгенография локтевой кости (2 проекции)"},
                    new ServiceType
                    {
                        Id = 1118024,
                        Code = "18024",
                        Name = "Рентгенография голеностопного сустава (2 проекции)"
                    },
                    new ServiceType {Id = 1118026, Code = "18026", Name = "Рентгенография пальцев стопы"},
                    new ServiceType
                    {
                        Id = 1118028,
                        Code = "18028",
                        Name = "Рентгенография тазобедренных суставов  в одной проекции"
                    },
                    new ServiceType {Id = 1118033, Code = "18033", Name = "Рентгенография кисти руки (2 проекции)"},
                    new ServiceType {Id = 1118035, Code = "18035", Name = "Рентгенография плечевого сустава"},
                    new ServiceType {Id = 1118037, Code = "18037", Name = "Рентгенография нижней челюсти (1 проекция)"},
                    new ServiceType {Id = 1118045, Code = "18045", Name = "Рентгенография грудины (2 проекции)"},
                    new ServiceType
                    {
                        Id = 1118048,
                        Code = "18048",
                        Name = "Обзорный снимок брюшной полости и органов малого таза"
                    },
                    new ServiceType
                    {
                        Id = 1118053,
                        Code = "18053",
                        Name = "Рентгенография поясничного отдела позвоночника (функционально)"
                    },
                    new ServiceType
                    {
                        Id = 1118062,
                        Code = "18062",
                        Name = "Контрастная рентгенография слезной железы и слезного протока"
                    },
                    new ServiceType {Id = 1118064, Code = "18064", Name = "Гистеросальпингография"},
                    new ServiceType {Id = 1118067, Code = "18067", Name = "Внутривенная урография (3 снимка)"},
                    new ServiceType {Id = 1118069, Code = "18069", Name = "Томография  костей"},
                    new ServiceType {Id = 1118071, Code = "18071", Name = "Томография  турецкого седла"},
                    new ServiceType {Id = 1118073, Code = "18073", Name = "Флюорография легких (две проекции)"},
                    new ServiceType {Id = 1123060, Code = "23060", Name = "Доварка базиса"},
                    new ServiceType
                    {
                        Id = 1123098,
                        Code = "23098",
                        Name = "Фарфор и металлокерамика: Изготовление десны искусственной"
                    },
                    new ServiceType {Id = 1123064, Code = "23064", Name = "Бюгельные протезы: Замок"},
                    new ServiceType {Id = 1123068, Code = "23068", Name = "Бюгельные протезы: Кламмер многозвеньевой"},
                    new ServiceType
                    {
                        Id = 1123070,
                        Code = "23070",
                        Name = "Бюгельные протезы: Коронка бюгельная цельнолитая"
                    },
                    new ServiceType {Id = 1123074, Code = "23074", Name = "Бюгельные протезы: Модель диагностическая"},
                    new ServiceType
                    {
                        Id = 1112072,
                        Code = "12072",
                        Name = "Удаление доброкачественных новообразований кожи аппаратом \"Сургитрон\" размером 1 мм."
                    },
                    new ServiceType {Id = 1113001, Code = "13001", Name = "Блокада семенного канатика"},
                    new ServiceType {Id = 1113004, Code = "13004", Name = "Массаж простаты"},
                    new ServiceType {Id = 1113006, Code = "13006", Name = "Диатермоэлектроэксцизия  уздечки"},
                    new ServiceType {Id = 1116091, Code = "16091", Name = "Исследование на гонококк"},
                    new ServiceType {Id = 1116107, Code = "16107", Name = "Нативный мазок на микрофлору"},
                    new ServiceType {Id = 1116122, Code = "16122", Name = "ДГЭА-SO4"},
                    new ServiceType {Id = 1116124, Code = "16124", Name = "Неконъюгированный эстриол"},
                    new ServiceType {Id = 1116125, Code = "16125", Name = "Общий тестостерон"},
                    new ServiceType {Id = 1116127, Code = "16127", Name = "Пролактин"},
                    new ServiceType {Id = 1116129, Code = "16129", Name = "Фолликулостимулирующий гормон (ФСГ)"},
                    new ServiceType {Id = 1116130, Code = "16130", Name = "ХГЧ"},
                    new ServiceType {Id = 1116134, Code = "16134", Name = "Т3 общий"},
                    new ServiceType {Id = 1116135, Code = "16135", Name = "Т4 общий"},
                    new ServiceType {Id = 1116138, Code = "16138", Name = "Тест поглощения тиреоидных гормонов"},
                    new ServiceType {Id = 1116140, Code = "16140", Name = "Тироксинсвязывающий глобуллин"},
                    new ServiceType {Id = 1116143, Code = "16143", Name = "СА 15-3"},
                    new ServiceType {Id = 1116144, Code = "16144", Name = "СА 19-9"},
                    new ServiceType {Id = 1116146, Code = "16146", Name = "АФП"},
                    new ServiceType {Id = 1116147, Code = "16147", Name = "Простатическая кислая фосфатаза"},
                    new ServiceType {Id = 1116149, Code = "16149", Name = "Свободный ПСА"},
                    new ServiceType {Id = 1116171, Code = "16171", Name = "АКТГ"},
                    new ServiceType {Id = 1116172, Code = "16172", Name = "Кортизол"},
                    new ServiceType {Id = 1116174, Code = "16174", Name = "Общий IgЕ"},
                    new ServiceType {Id = 1116175, Code = "16175", Name = "Кальцитонин"},
                    new ServiceType {Id = 1116177, Code = "16177", Name = "Остеокальцин"},
                    new ServiceType {Id = 1116178, Code = "16178", Name = "Паратиреоидный гормон"},
                    new ServiceType {Id = 1114018, Code = "14018", Name = "Аденоидэктомия"},
                    new ServiceType {Id = 1114030, Code = "14030", Name = "Промывание лакун миндалин вручную"},
                    new ServiceType
                    {
                        Id = 1115010,
                        Code = "15010",
                        Name = "Прерывание беременности в малом сроке методом вакуум-аспирации"
                    },
                    new ServiceType {Id = 1115013, Code = "15013", Name = "Инстилляция уретры"},
                    new ServiceType {Id = 1115015, Code = "15015", Name = "Тампонирование лечебное влагалища"},
                    new ServiceType
                    {
                        Id = 1115016,
                        Code = "15016",
                        Name = "Гистеросальпингография (без стоимости контраста и рентгенисследований)"
                    },
                    new ServiceType
                    {
                        Id = 1121042,
                        Code = "21042",
                        Name = "Закрытый кюретаж при болезнях пародонта в области  двух зубов"
                    },
                    new ServiceType
                    {
                        Id = 1121044,
                        Code = "21044",
                        Name = "Введение лекарственных средств в патологические зубодесневые карманы"
                    },
                    new ServiceType
                    {
                        Id = 1121060,
                        Code = "21060",
                        Name = "Инструментальная и медикаментозная обработка корневого канала"
                    },
                    new ServiceType
                    {
                        Id = 1122005,
                        Code = "22005",
                        Name = "Сложное удаление зуба с разъединением корней с отечественным анестетиком"
                    },
                    new ServiceType
                    {
                        Id = 1122009,
                        Code = "22009",
                        Name = "Удаление ретенированного зуба  с отечественным анестетиком"
                    },
                    new ServiceType
                    {
                        Id = 1122016,
                        Code = "22016",
                        Name = "Операция резекции верхушки корня одного  резца или клыка"
                    },
                    new ServiceType
                    {
                        Id = 1122018,
                        Code = "22018",
                        Name = "Операция цистектомии в области одного резца или клыка без удаления зубов"
                    },
                    new ServiceType {Id = 1122027, Code = "22027", Name = "Операция: пластика уздечки губы, языка"},
                    new ServiceType
                    {
                        Id = 1122037,
                        Code = "22037",
                        Name = "Первичная хирургическая обработка мягких тканей или полости рта без наложения швов"
                    },
                    new ServiceType
                    {
                        Id = 1122040,
                        Code = "22040",
                        Name = "Снятие швов после оперативного вмешательства в челюстно-лицевой области"
                    },
                    new ServiceType
                    {
                        Id = 1122041,
                        Code = "22041",
                        Name = "Сложное удаление зуба с разъединением корней с импортным анестетиком"
                    },
                    new ServiceType
                    {
                        Id = 1122056,
                        Code = "22056",
                        Name =
                            "Лечение заболевания слюнных желез (каждое посещение, бужирование протоков, в т.ч. височно - нижнечелюстного сустава)"
                    },
                    new ServiceType
                    {
                        Id = 1122057,
                        Code = "22057",
                        Name =
                            "Сложное удаление зуба с выпиливанием кортик.пластинки альвеольного отростка под инъекционной анестезией"
                    },
                    new ServiceType {Id = 1123006, Code = "23006", Name = "Коронка литая из стали (цельнолитая)"},
                    new ServiceType {Id = 1123012, Code = "23012", Name = "Зуб литой с фасеткой (металлоакриловый)"},
                    new ServiceType {Id = 1123018, Code = "23018", Name = "Спайка деталей"},
                    new ServiceType {Id = 1123019, Code = "23019", Name = "Снятие, цементировка коронки"},
                    new ServiceType {Id = 1123022, Code = "23022", Name = "Реставрация фасетки пластмассой"},
                    new ServiceType {Id = 1123031, Code = "23031", Name = "Кламмер гнутый из проволоки"},
                    new ServiceType {Id = 1123052, Code = "23052", Name = "Перелом 1 починка перелома"},
                    new ServiceType {Id = 1123053, Code = "23053", Name = "Перелом 2 починка перелома двух"},
                    new ServiceType
                    {
                        Id = 1123055,
                        Code = "23055",
                        Name = "Реставрация съемного протеза после удаления двух зубов, приварка двух зубов"
                    },
                    new ServiceType
                    {
                        Id = 1123056,
                        Code = "23056",
                        Name = "Реставрация съемного протеза после удаления трех зубов, приварка трех зубов"
                    },
                    new ServiceType {Id = 1123058, Code = "23058", Name = "Приварка одного кламмера"},
                    new ServiceType
                    {
                        Id = 1123061,
                        Code = "23061",
                        Name = "Бюгельные протезы: Дуга бюгельная на нижнюю челюсть с креплением на кламмерах"
                    },
                    new ServiceType {Id = 1123065, Code = "23065", Name = "Бюгельные протезы: Интерлок"},
                    new ServiceType
                    {
                        Id = 1123069,
                        Code = "23069",
                        Name = "Бюгельные протезы: Изготовление штампованной стальной коронки бюгельной"
                    },
                    new ServiceType {Id = 1123073, Code = "23073", Name = "Бюгельные протезы: Модель контрольная"},
                    new ServiceType
                    {
                        Id = 1118076,
                        Code = "18076",
                        Name = "Флюорография костей и суставов в одной проекции"
                    },
                    new ServiceType
                    {
                        Id = 1118079,
                        Code = "18079",
                        Name = "Радиовизиография зубов с распечаткой снимков"
                    },
                    new ServiceType {Id = 1118083, Code = "18083", Name = "Повторное описание флюорограммы"},
                    new ServiceType
                    {
                        Id = 1118085,
                        Code = "18085",
                        Name = "Рентгенография грудной клетки в боковой проекции"
                    },
                    new ServiceType
                    {
                        Id = 1111001,
                        Code = "11001",
                        Name = "Школа для больных с артериальной гипертензией"
                    },
                    new ServiceType
                    {
                        Id = 1111005,
                        Code = "11005",
                        Name = "Исследование неспровоцированных дыхательных объемов и потоков"
                    },
                    new ServiceType
                    {
                        Id = 1111007,
                        Code = "11007",
                        Name =
                            "Расшифровка, описание и интерпретация электрокардиографических данных электрокардиографии с физическими упражнениями"
                    },
                    new ServiceType {Id = 1111010, Code = "11010", Name = "Реовазография с пробой"},
                    new ServiceType {Id = 1111014, Code = "11014", Name = "Эхо-энцефалоскопия"},
                    new ServiceType {Id = 1111016, Code = "11016", Name = "Взятие крови из периферической вены"},
                    new ServiceType
                    {
                        Id = 1111027,
                        Code = "11027",
                        Name = "Криодеструкция доброкачественных образований кожи"
                    },
                    new ServiceType {Id = 1111029, Code = "11029", Name = "Криодеструкция рубцов кожи"},
                    new ServiceType {Id = 1111036, Code = "11036", Name = "Пара- и ретробульбарные инъекции"},
                    new ServiceType
                    {
                        Id = 1111040,
                        Code = "11040",
                        Name = "Биомикроскопия конъюнктивы с помощью щелевой лампы"
                    },
                    new ServiceType {Id = 1111048, Code = "11048", Name = "Удаление инородного тела глаза"},
                    new ServiceType {Id = 1111052, Code = "11052", Name = "Вскрытие ячменя, абсцесса века"},
                    new ServiceType {Id = 1111054, Code = "11054", Name = "Дуплексное сканирование артерий головы"},
                    new ServiceType
                    {
                        Id = 1111058,
                        Code = "11058",
                        Name = "Дуплексное сканирование вен верхней  конечности"
                    },
                    new ServiceType
                    {
                        Id = 1111061,
                        Code = "11061",
                        Name = "Комплексное ультразвуковое исследование органов брюшной полости (без почек)"
                    },
                    new ServiceType
                    {
                        Id = 1111062,
                        Code = "11062",
                        Name =
                            "Комплексное ультразвуковое исследование органов брюшной полости с определением функции жёлчного пузыря"
                    },
                    new ServiceType
                    {
                        Id = 1111065,
                        Code = "11065",
                        Name = "Комплексное ультразвуковое исследование органов брюшной полости и почек"
                    },
                    new ServiceType
                    {
                        Id = 1111070,
                        Code = "11070",
                        Name = "Ультразвуковое исследование матки и придатков с применением трансвагинального датчика"
                    },
                    new ServiceType
                    {
                        Id = 1111072,
                        Code = "11072",
                        Name = "Ультразвуковое исследование органов матки и придатков в 1 триместре  беременности"
                    },
                    new ServiceType {Id = 1111074, Code = "11074", Name = "Ультразвуковое исследование простаты"},
                    new ServiceType
                    {
                        Id = 1111076,
                        Code = "11076",
                        Name = "Ультразвуковое исследование мошонки (яички, придатки)"
                    },
                    new ServiceType
                    {
                        Id = 1111077,
                        Code = "11077",
                        Name =
                            "Ультразвуковое исследование мошонки (яички, придатки) с ЦДК сосудов семенного канатика и объемных образований"
                    },
                    new ServiceType
                    {
                        Id = 1111080,
                        Code = "11080",
                        Name = "Ультразвуковое исследование щитовидной железы при пункционной биопсии"
                    },
                    new ServiceType
                    {
                        Id = 1111082,
                        Code = "11082",
                        Name =
                            "Ультразвуковое исследование молочных желез  с исследованием сосудов и кровотока объемных образований"
                    },
                    new ServiceType
                    {
                        Id = 1111084,
                        Code = "11084",
                        Name = "Ультразвуковое исследование грудных желез у мужчин"
                    },
                    new ServiceType {Id = 1111100, Code = "11100", Name = "Паравертебральная  блокада"},
                    new ServiceType
                    {
                        Id = 1111102,
                        Code = "11102",
                        Name = "Ультразвуковое исследование мочевого пузыря       с ЦДК"
                    },
                    new ServiceType
                    {
                        Id = 1111104,
                        Code = "11104",
                        Name = "Исследование  дыхательных объемов при медикаментозной провокации"
                    },
                    new ServiceType {Id = 1111126, Code = "11126", Name = "Холтеровское мониторирование ЭКГ"},
                    new ServiceType {Id = 1123077, Code = "23077", Name = "Бюгельные протезы: Модель рабочая"},
                    new ServiceType {Id = 1116137, Code = "16137", Name = "Т4 свободный"},
                    new ServiceType {Id = 1116159, Code = "16159", Name = "Ферритин"},
                    new ServiceType {Id = 1116166, Code = "16166", Name = "Фактор некроза опухоли"},
                    new ServiceType {Id = 1118001, Code = "18001", Name = "Рентгеноскопия органов грудной клетки"},
                    new ServiceType {Id = 1118019, Code = "18019", Name = "Рентгенография костей предплечья"},
                    new ServiceType {Id = 1118068, Code = "18068", Name = "Внутривенная урография (4 снимка)"},
                    new ServiceType
                    {
                        Id = 1118088,
                        Code = "18088",
                        Name = "Рентгенография коленного, локтевого, голеностопного, лучезапястного сустава(1 проекция)"
                    },
                    new ServiceType {Id = 1111094, Code = "11094", Name = "Ультразвуковое исследование селезенки"},
                    new ServiceType
                    {
                        Id = 1112031,
                        Code = "12031",
                        Name = "Лечение гемороя на приборе IRC основной курс (один узел)"
                    },
                    new ServiceType {Id = 1116506, Code = "16506", Name = "MCH"},
                    new ServiceType {Id = 1116605, Code = "16605", Name = "Удельный вес"},
                    new ServiceType {Id = 1116610, Code = "16610", Name = "Цилиндры"},
                    new ServiceType {Id = 1116617, Code = "16617", Name = "Слизь"},
                    new ServiceType {Id = 1116874, Code = "16874", Name = "Полость глаза"},
                    new ServiceType {Id = 1116881, Code = "16881", Name = "Мокрота"},
                    new ServiceType {Id = 1116885, Code = "16885", Name = "Ликвор"},
                    new ServiceType {Id = 1116705, Code = "16705", Name = "Слизь"},
                    new ServiceType {Id = 1204015, Code = "", Name = "Инфекции"},
                    new ServiceType {Id = 1203011, Code = "", Name = "УЗИ"},
                    new ServiceType {Id = 1203020, Code = "", Name = "Физиолечение"},
                    new ServiceType {Id = 1203090, Code = "", Name = "Хирургия"},
                    new ServiceType {Id = 1204080, Code = "", Name = "Школа больных"},
                    new ServiceType {Id = 1118099, Code = "18099", Name = "МСКТ височных костей"},
                    new ServiceType {Id = 1119027, Code = "19027", Name = "Ультразвуковое лечение"},
                    new ServiceType {Id = 1116703, Code = "16703", Name = "Лейкоциты"},
                    new ServiceType {Id = 1125870, Code = "25870", Name = "Гематологические исследования"},
                    new ServiceType {Id = 1116000, Code = "16000", Name = "Биохимический анализ крови"},
                    new ServiceType {Id = 1202025, Code = "", Name = "БАК-исследования"},
                    new ServiceType {Id = 1204011, Code = "", Name = "Маркеры нарушений углеводного обмена"},
                    new ServiceType {Id = 1204016, Code = "", Name = "Гормоны щитовидной железы"},
                    new ServiceType {Id = 1202003, Code = "", Name = "Срочные лаб. исследования"},
                    new ServiceType {Id = 1203030, Code = "", Name = "Флюорографические исследования"},
                    new ServiceType {Id = 1203043, Code = "", Name = "Рентгеноскопия"},
                    new ServiceType {Id = 1203080, Code = "", Name = "Дневной стационар"},
                    new ServiceType {Id = 1203130, Code = "21000", Name = "Стоматология"},
                    new ServiceType {Id = 1204070, Code = "", Name = "Оформление документов"},
                    new ServiceType {Id = 1205021, Code = "", Name = "Лабораторные исследования (кардиолог)"},
                    new ServiceType {Id = 1206111, Code = "", Name = "По сан. книжке (перв. муж.)"},
                    new ServiceType {Id = 1112036, Code = "12036", Name = "Обрезание крайней плоти"},
                    new ServiceType
                    {
                        Id = 1112048,
                        Code = "12048",
                        Name = "Вскрытие костного панариция, карбункула, флегмоны, нагноившейся гематомы"
                    },
                    new ServiceType {Id = 1122052, Code = "22052", Name = "Операция подсечения уздечки губы, языка"},
                    new ServiceType
                    {
                        Id = 1206487,
                        Code = "22068",
                        Name = "Операция расширения альвеолярного гребня с BIO-GIDE 25мм х 25мм"
                    },
                    new ServiceType {Id = 1123008, Code = "23008", Name = "Облицовка пластмассой"},
                    new ServiceType {Id = 1123017, Code = "23017", Name = "Лапка (накладная оклюзационная)"},
                    new ServiceType {Id = 1123033, Code = "23033", Name = "Кламмер опорноудерживающий"},
                    new ServiceType
                    {
                        Id = 1123057,
                        Code = "23057",
                        Name = "Реставрация съемного протеза после удаления четырех,  зубов приварка четырех зубов"
                    },
                    new ServiceType
                    {
                        Id = 1123063,
                        Code = "23063",
                        Name = "Дуга верхняя (нижняя) бюгельная с замковым креплением"
                    },
                    new ServiceType
                    {
                        Id = 1123066,
                        Code = "23066",
                        Name = "Бюгельные протезы: Коронка бюгельная опорная МК"
                    },
                    new ServiceType {Id = 1123076, Code = "23076", Name = "Бюгельные протезы: Модель огнеупорная"},
                    new ServiceType {Id = 1123086, Code = "23086", Name = "Перебазировка съемного протеза"},
                    new ServiceType {Id = 1122033, Code = "22033", Name = "Операция гемисекции одного корня"},
                    new ServiceType {Id = 1123001, Code = "23001", Name = "Коронка металическая (штампованная)"},
                    new ServiceType
                    {
                        Id = 1124002,
                        Code = "24002",
                        Name =
                            "Лечение больного в дневном стационаре включая стоимость лекарственных средств (терапевтический профиль)"
                    },
                    new ServiceType {Id = 1117097, Code = "17097", Name = "ДНК вируса гепатита В, качественный"},
                    new ServiceType {Id = 1206302, Code = "16186", Name = "Определение тропонина J"},
                    new ServiceType {Id = 1206312, Code = "18128", Name = "Томография гортани"},
                    new ServiceType {Id = 1206321, Code = "11153", Name = "Ультразвуковая допплерография сосудов глаза"},
                    new ServiceType
                    {
                        Id = 1206335,
                        Code = "16110",
                        Name = "Исследование уровня С-реактивного белка в крови (количественно)"
                    },
                    new ServiceType {Id = 1206350, Code = "23124", Name = "Снятие 1-го оттиска альгинатного"},
                    new ServiceType {Id = 1116031, Code = "16031", Name = "Белок (общ.)"},
                    new ServiceType {Id = 1116059, Code = "16059", Name = "Альфа амилаза"},
                    new ServiceType {Id = 1116070, Code = "16070", Name = "Волчаночный антикоагулянт"},
                    new ServiceType {Id = 1116136, Code = "16136", Name = "Т3 свободный"},
                    new ServiceType {Id = 1116150, Code = "16150", Name = "Anti-HBs количественный"},
                    new ServiceType {Id = 1116180, Code = "16180", Name = "IgМ к цитомегаловирусу"},
                    new ServiceType {Id = 1118016, Code = "18016", Name = "Рентгенография бедренной кости (2 проекции)"},
                    new ServiceType {Id = 1118040, Code = "18040", Name = "Рентгенография зубов"},
                    new ServiceType
                    {
                        Id = 1118074,
                        Code = "18074",
                        Name = "Флюорография шейного отдела позвоночника в двух проекциях"
                    },
                    new ServiceType
                    {
                        Id = 1111063,
                        Code = "11063",
                        Name =
                            "Комплексное ультразвуковое исследование органов брюшной полости с исследованием портального кровотока"
                    },
                    new ServiceType
                    {
                        Id = 1111142,
                        Code = "11142",
                        Name = "Ультразвуковое исследование простаты с определением объема остаточной мочи"
                    },
                    new ServiceType
                    {
                        Id = 1114009,
                        Code = "14009",
                        Name = "НУЗ-терапия:1 сеанс фонофорез с озвучиванием"
                    },
                    new ServiceType
                    {
                        Id = 1118117,
                        Code = "18117",
                        Name = "КТ с в/в болюсным контрастированием без стоимости контрастного вещества"
                    },
                    new ServiceType {Id = 1122031, Code = "22031", Name = "Операция удаления камня из слюнного протока"},
                    new ServiceType {Id = 1123036, Code = "23036", Name = "Снятие 1-го оттиска силиконового"},
                    new ServiceType
                    {
                        Id = 1123107,
                        Code = "23107",
                        Name = "Съемные протезы пластмассовые: Зуб пять (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1125017,
                        Code = "25017",
                        Name = "Медицинский осмотр с оформлением других справок  (мужчины)"
                    },
                    new ServiceType {Id = 1204020, Code = "", Name = "Маркеры нарушения метаболизма костной ткани"},
                    new ServiceType {Id = 1116139, Code = "16139", Name = "Тиреоглобуллин"},
                    new ServiceType {Id = 1206323, Code = "11155", Name = "Ультразвуковое исследование почек с ЦДК"},
                    new ServiceType {Id = 1113008, Code = "13008", Name = "Катетеризация мочевого пузыря"},
                    new ServiceType {Id = 1114007, Code = "14007", Name = "Промывание пазух носа методом перемещения"},
                    new ServiceType {Id = 1114011, Code = "14011", Name = "Вскрытие фурункула  ЛОР-органов"},
                    new ServiceType
                    {
                        Id = 1114015,
                        Code = "14015",
                        Name = "Пункция верхнечелюстной пазухи носа (односторонняя)"
                    },
                    new ServiceType
                    {
                        Id = 1114016,
                        Code = "14016",
                        Name = "Удаление полипов носовых ходов (одностороннее)"
                    },
                    new ServiceType
                    {
                        Id = 1114033,
                        Code = "14033",
                        Name = "Удаление  доброкачественных новообразований ЛОР-органов"
                    },
                    new ServiceType
                    {
                        Id = 1115001,
                        Code = "15001",
                        Name = "Прием (осмотр, консультация) врачом-акушером-гинекологом беременной первичный"
                    },
                    new ServiceType
                    {
                        Id = 1115002,
                        Code = "15002",
                        Name = "Прием (осмотр, консультация) врачом-акушером-гинекологом беременной повторный"
                    },
                    new ServiceType
                    {
                        Id = 1118110,
                        Code = "18110",
                        Name = "МСКТ органов малого таза с болюсным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1118115,
                        Code = "18115",
                        Name = "МСКТ ангиография подвздошно - бедренных артерий с болюсным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1118119,
                        Code = "18119",
                        Name = "Введение контрастного вещества для болюсного контрастирования"
                    },
                    new ServiceType {Id = 1118123, Code = "18123", Name = "МСКТ головного мозга"},
                    new ServiceType {Id = 1119004, Code = "19004", Name = "Массаж"},
                    new ServiceType {Id = 1119005, Code = "19005", Name = "Мануальная терапия (1 сеанс)"},
                    new ServiceType {Id = 1119009, Code = "19009", Name = "Диадинамофорез"},
                    new ServiceType {Id = 1119014, Code = "19014", Name = "Дарсонвализация местная"},
                    new ServiceType {Id = 1119021, Code = "19021", Name = "Миоэлектростимуляция"},
                    new ServiceType {Id = 1119026, Code = "19026", Name = "КУФ-облучение на аппарате Эндоламп - 474"},
                    new ServiceType {Id = 1119031, Code = "19031", Name = "Лазерная пунктура"},
                    new ServiceType {Id = 1121013, Code = "21013", Name = "Пломбирование канала пастой"},
                    new ServiceType {Id = 1121017, Code = "21017", Name = "Раскрытие корневого канала"},
                    new ServiceType
                    {
                        Id = 1121019,
                        Code = "21019",
                        Name = "Полная реставрация светоотверждаемым материалом"
                    },
                    new ServiceType {Id = 1121023, Code = "21023", Name = "Лечение периодонтита многокорневого зуба"},
                    new ServiceType {Id = 1121036, Code = "21036", Name = "Обучение гигиене полости рта и зубов"},
                    new ServiceType {Id = 1112066, Code = "12066", Name = "Исследование материала на наличие H.pilori"},
                    new ServiceType {Id = 1206199, Code = "", Name = "Прочие услуги (эндокринолог)"},
                    new ServiceType
                    {
                        Id = 1123112,
                        Code = "23112",
                        Name = "Съемные протезы пластмассовые: Зуб десять(частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123116,
                        Code = "23116",
                        Name = "Съемные протезы пластмассовые: Зуб четырнадцать (полный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1124001,
                        Code = "24001",
                        Name =
                            "Лечение больного в дневном стационаре (без учета стоимости лекарств и услуг других подразделений поликлиники)"
                    },
                    new ServiceType
                    {
                        Id = 1124003,
                        Code = "24003",
                        Name =
                            "Лечение больного в дневном стационаре включая стоимость лекарственных средств (неврологический профиль)"
                    },
                    new ServiceType
                    {
                        Id = 1125002,
                        Code = "25002",
                        Name = "Профилактический прием (осмотр, консультация) врача-невролога"
                    },
                    new ServiceType
                    {
                        Id = 1125005,
                        Code = "25005",
                        Name = "Профилактический прием (осмотр, консультация) врача-офтальмолога"
                    },
                    new ServiceType
                    {
                        Id = 1125006,
                        Code = "25006",
                        Name = "Профилактический прием (осмотр, консультация) врача-акушера-гинеколога"
                    },
                    new ServiceType
                    {
                        Id = 1125007,
                        Code = "25007",
                        Name = "Профилактический прием (осмотр, консультация) врача-оториноларинголога"
                    },
                    new ServiceType
                    {
                        Id = 1125012,
                        Code = "25012",
                        Name = "Медицинский осмотр декретированного населения (санитарная книжка) - мужчины"
                    },
                    new ServiceType
                    {
                        Id = 1125018,
                        Code = "25018",
                        Name =
                            "Медицинский осмотр о годности к управлению транспортными средствами (водительская справка)"
                    },
                    new ServiceType {Id = 1125023, Code = "25023", Name = "Тональная аудиометрия"},
                    new ServiceType
                    {
                        Id = 1125024,
                        Code = "25024",
                        Name = "Исследование неспровоцированных дыхательных объемов и потоков"
                    },
                    new ServiceType
                    {
                        Id = 1125045,
                        Code = "25045",
                        Name = "Бактериологическое исследование на носительство стафилококка"
                    },
                    new ServiceType
                    {
                        Id = 1125050,
                        Code = "25050",
                        Name =
                            "Медицинский осмотр о годности к управлению транспортными средствами (водительская справка) при одновременном прохождении периодического медосмотра"
                    },
                    new ServiceType {Id = 1206359, Code = "", Name = "Медосмотр - Гипротюменнефтегаз"},
                    new ServiceType {Id = 1125040, Code = "25040", Name = "Подбор очков (сложный)"},
                    new ServiceType
                    {
                        Id = 1206306,
                        Code = "16190",
                        Name = "Исследование отделяемого молочной железы на скрытую кровь"
                    },
                    new ServiceType {Id = 1206342, Code = "16198", Name = "ТТГ"},
                    new ServiceType {Id = 1118032, Code = "18032", Name = "Рентгенография ключицы"},
                    new ServiceType {Id = 1118041, Code = "18041", Name = "Рентгенография костей носа (1 проекция)"},
                    new ServiceType
                    {
                        Id = 1118042,
                        Code = "18042",
                        Name = "Рентгенография пяточной кости (одной проекця)"
                    },
                    new ServiceType {Id = 1118059, Code = "18059", Name = "Томография верхушек легких"},
                    new ServiceType {Id = 1118066, Code = "18066", Name = "Рентгенография  стоп с нагрузкой"},
                    new ServiceType
                    {
                        Id = 1118075,
                        Code = "18075",
                        Name = "Флюорография шейного отдела позвоночника  в четырех поекциях"
                    },
                    new ServiceType {Id = 1118080, Code = "18080", Name = "Ортопантомография"},
                    new ServiceType {Id = 1118091, Code = "18091", Name = "Распечатка визиограммы"},
                    new ServiceType
                    {
                        Id = 1206310,
                        Code = "18126",
                        Name = "Рентгенография локтевого сустава (2 проекции)"
                    },
                    new ServiceType {Id = 1119016, Code = "19016", Name = "УВЧ-терапия"},
                    new ServiceType {Id = 1119024, Code = "19024", Name = "Ультрафиолетовое облучение кожи"},
                    new ServiceType
                    {
                        Id = 1119032,
                        Code = "19032",
                        Name = "Лазерная терапия на гелий-неоновом лазере Шатл"
                    },
                    new ServiceType {Id = 1121010, Code = "21010", Name = "Лечение кариеса  с лечебной прокладкой"},
                    new ServiceType {Id = 1121016, Code = "21016", Name = "Трепанация коронки зуба"},
                    new ServiceType {Id = 1121024, Code = "21024", Name = "Снятие временной пломбы"},
                    new ServiceType {Id = 1122045, Code = "22045", Name = "Удаление зуба  с отечественным анестетиком"},
                    new ServiceType
                    {
                        Id = 1122051,
                        Code = "22051",
                        Name = "Коррекция перикоронита (промывание, рассечение)"
                    },
                    new ServiceType {Id = 1122054, Code = "22054", Name = "Пластика перфорации верхнечелюстной пазухи"},
                    new ServiceType
                    {
                        Id = 1206346,
                        Code = "22058",
                        Name = "Операция удаления дистопированного или сверхкомплектного зуба"
                    },
                    new ServiceType {Id = 1206483, Code = "22064", Name = "Установка формирователя десны"},
                    new ServiceType {Id = 1123004, Code = "23004", Name = "Коронка телескопическая фрезерованная"},
                    new ServiceType {Id = 1123005, Code = "23005", Name = "Коронка с облицовкой (комбинированная)"},
                    new ServiceType {Id = 1123011, Code = "23011", Name = "Зуб литой стальной"},
                    new ServiceType
                    {
                        Id = 1118102,
                        Code = "18102",
                        Name = "Запись результатов на компакт диск (дополнительно к любому исследованию)"
                    },
                    new ServiceType
                    {
                        Id = 1111098,
                        Code = "11098",
                        Name = "Взятие крови из вены в дополнительную одноразовую систему"
                    },
                    new ServiceType
                    {
                        Id = 1206619,
                        Code = "11164",
                        Name =
                            "Взятие крови из периферической вены в дополнительную одноразовую систему (более чем одна пробирка)"
                    },
                    new ServiceType
                    {
                        Id = 1206639,
                        Code = "21063",
                        Name = "Фиксация стекловолоконного штифта в корневом канале"
                    },
                    new ServiceType {Id = 1206624, Code = "17110", Name = "Генотипирование вируса гепатита С"},
                    new ServiceType
                    {
                        Id = 1206625,
                        Code = "17111",
                        Name =
                            "Патагистологическое исследование операционного и биопсийного материала 1 категории сложности"
                    },
                    new ServiceType
                    {
                        Id = 1206627,
                        Code = "17113",
                        Name =
                            "Патагистологическое исследование операционного и биопсийного материала 4 категории сложности"
                    },
                    new ServiceType {Id = 1116006, Code = "16006", Name = "Подсчет тромбоцитов"},
                    new ServiceType {Id = 1116013, Code = "16013", Name = "Общий анализ мочи"},
                    new ServiceType {Id = 1116055, Code = "16055", Name = "Фосфор неорганический"},
                    new ServiceType {Id = 1116084, Code = "16084", Name = "Исследование крови на стерильность"},
                    new ServiceType
                    {
                        Id = 1111132,
                        Code = "11132",
                        Name = "Дуплексное сканирование нижней полой вены и вен малого таза"
                    },
                    new ServiceType
                    {
                        Id = 1111134,
                        Code = "11134",
                        Name =
                            "Ультразвуковая допплерография ветвей дуги аорты с ветвями (брахиоцефальный ствол, подключичные, общие сонные артерии)"
                    },
                    new ServiceType
                    {
                        Id = 1111135,
                        Code = "11135",
                        Name = "Дуплексное сканирование почечных и яичковых вен при варикоцеле"
                    },
                    new ServiceType
                    {
                        Id = 1111136,
                        Code = "11136",
                        Name =
                            "Ультразвуковое исследование во 2 и 3 триместрах  беременности с видеозаписью жизнедеятольности плода"
                    },
                    new ServiceType
                    {
                        Id = 1111141,
                        Code = "11141",
                        Name = "Дуплексное сканирование артерий вертебрально-базилярного бассейна"
                    },
                    new ServiceType
                    {
                        Id = 1111144,
                        Code = "11144",
                        Name = "Ультразвуковое исследование полового члена  с ЦДК"
                    },
                    new ServiceType
                    {
                        Id = 1112011,
                        Code = "12011",
                        Name = "Операция по поводу удаления вросшего ногтя с иссечением матрицы"
                    },
                    new ServiceType {Id = 1112014, Code = "12014", Name = "Склеротерапия"},
                    new ServiceType
                    {
                        Id = 1112019,
                        Code = "12019",
                        Name = "Биопсия пункционная тонкоигольная под контролем УЗИ (без стоимости УЗИ)"
                    },
                    new ServiceType
                    {
                        Id = 1112028,
                        Code = "12028",
                        Name = "Гипсование при переломах костей (гипс малый - мелкие суставы)"
                    },
                    new ServiceType {Id = 1112069, Code = "12069", Name = "Перевязки при операциях на органе зрения"},
                    new ServiceType {Id = 1206686, Code = "15031", Name = "Взятие мазка на Gn"},
                    new ServiceType {Id = 1118050, Code = "18050", Name = "Рентгенография легких (прицельная)"},
                    new ServiceType
                    {
                        Id = 1125064,
                        Code = "25064",
                        Name = "Исследование крови на вирусный гепатит В (Hbs Ag)"
                    },
                    new ServiceType
                    {
                        Id = 1118112,
                        Code = "18112",
                        Name = "МСКТ ангиография интракраниальных артерий с болюсным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1121031,
                        Code = "21031",
                        Name = "Прием (осмотр, консультация) врача стоматолога-пародонтолога"
                    },
                    new ServiceType
                    {
                        Id = 1206485,
                        Code = "22066",
                        Name = "Операция синус-лифтинг с коллапаном 1 шарик (за каждый дополнительный 1 шарик-80р)"
                    },
                    new ServiceType
                    {
                        Id = 1206314,
                        Code = "11157",
                        Name = "Дуплексное сканирование вен нижней  конечности"
                    },
                    new ServiceType
                    {
                        Id = 1206626,
                        Code = "17112",
                        Name =
                            "Патагистологическое исследование операционного и биопсийного материала 2 категории сложности"
                    },
                    new ServiceType
                    {
                        Id = 1206628,
                        Code = "17114",
                        Name =
                            "Патагистологическое исследование операционного и биопсийного материала 4 категории сложности"
                    },
                    new ServiceType
                    {
                        Id = 1112065,
                        Code = "12065",
                        Name = "Прием (осмотр, консультация) врача - эндоскописта"
                    },
                    new ServiceType {Id = 1114020, Code = "14020", Name = "Тональная аудиометрия"},
                    new ServiceType {Id = 1116082, Code = "16082", Name = "Исследование на кандидоз одного отделяемого"},
                    new ServiceType
                    {
                        Id = 1118101,
                        Code = "18101",
                        Name = "КТ - навигация при манипуляциях (пункции, блокады, дренирования)"
                    },
                    new ServiceType {Id = 1121022, Code = "21022", Name = "Лечение периодонтита однокорневого зуба"},
                    new ServiceType
                    {
                        Id = 1122036,
                        Code = "22036",
                        Name = "Остановка луночного кровотечения з.тампонадой"
                    },
                    new ServiceType
                    {
                        Id = 1125021,
                        Code = "25021",
                        Name = "Регистрация электрокардиограммы с расшифровкой"
                    },
                    new ServiceType {Id = 1203120, Code = "", Name = "Гинекология"},
                    new ServiceType {Id = 1205022, Code = "", Name = "R-исследования (кардиолог)"},
                    new ServiceType
                    {
                        Id = 1118100,
                        Code = "18100",
                        Name = "МСКТ одной анатомической области по согласованию с рентренологом"
                    },
                    new ServiceType {Id = 1111024, Code = "11024", Name = "Криомассаж  кожи головы"},
                    new ServiceType {Id = 1111133, Code = "11133", Name = "Дуплексное сканирование маммарных артерий"},
                    new ServiceType {Id = 1112080, Code = "12080", Name = "Лимфотропное введение лекарственных средств"},
                    new ServiceType {Id = 1123121, Code = "23121", Name = "Импортная базисная пластмасса"},
                    new ServiceType {Id = 1206179, Code = "", Name = "R-исследования (эндокринолог)"},
                    new ServiceType {Id = 1206334, Code = "16109", Name = "Обнаружение кетоновых тел в моче"},
                    new ServiceType {Id = 1116088, Code = "16088", Name = "Исследование на урогенитальные микоплазмы"},
                    new ServiceType
                    {
                        Id = 1111020,
                        Code = "11020",
                        Name = "Подкожное введение лекарственных средств и растворов"
                    },
                    new ServiceType {Id = 1121027, Code = "21027", Name = "Извлечение инородного тела из канала"},
                    new ServiceType {Id = 1202053, Code = "", Name = "Исследование крови"},
                    new ServiceType {Id = 1205011, Code = "", Name = "Лабораторные исследования (невролог)"},
                    new ServiceType
                    {
                        Id = 1124010,
                        Code = "24010",
                        Name = "Прием (осмотр,консультация) врача дневного стационара первичный"
                    },
                    new ServiceType {Id = 1123123, Code = "23123", Name = "Временная пластмассоваю коронка, зуб"},
                    new ServiceType {Id = 1119038, Code = "19038", Name = "Микрорезонансная терапия"},
                    new ServiceType {Id = 1121007, Code = "21007", Name = "Наложение мышьяковистой пасты"},
                    new ServiceType
                    {
                        Id = 1121039,
                        Code = "21039",
                        Name = "Применение реминерализующих препаратов у одного зуба: Бифлюорид"
                    },
                    new ServiceType
                    {
                        Id = 1206479,
                        Code = "23143",
                        Name =
                            "Фарфор и металлокерамика:Изготовление зуба металлокерамического на основе неблагородных металлов на имплантате"
                    },
                    new ServiceType
                    {
                        Id = 1206482,
                        Code = "22063",
                        Name = "Операция синус-лифтинг с BIO-OSS, 0,5,фл (за каждый следующий 0,5,фл-3400р)"
                    },
                    new ServiceType {Id = 1206486, Code = "22067", Name = "Операция расширения альвеолярного гребня"},
                    new ServiceType
                    {
                        Id = 1206488,
                        Code = "22069",
                        Name = "Операция увеличения размеров альвеолярной кости с использованием брефокости"
                    },
                    new ServiceType
                    {
                        Id = 1206489,
                        Code = "22070",
                        Name =
                            "Операция увеличения размеров альвеолярной кости с использованием деминерализованой крошки 2см.куб. (за каждых дополнительных 2см.куб.-1800р)"
                    },
                    new ServiceType {Id = 1112060, Code = "12060", Name = "Эзофагогастродуоденоскопия"},
                    new ServiceType {Id = 1115007, Code = "15007", Name = "Биопсия с помощью эндоскопа"},
                    new ServiceType
                    {
                        Id = 1115018,
                        Code = "15018",
                        Name = "Лечение заболеваний шейки матки аппаратом \"Сургитрон\""
                    },
                    new ServiceType {Id = 1206300, Code = "16184", Name = "Определение Jg M к Hbс - антигену"},
                    new ServiceType {Id = 1116020, Code = "16020", Name = "Кал на яйца глистов"},
                    new ServiceType
                    {
                        Id = 1110008,
                        Code = "10008",
                        Name = "Прием (осмотр, консультация) врача-специалиста второй категории"
                    },
                    new ServiceType {Id = 1111013, Code = "11013", Name = "Реоэнцефалография"},
                    new ServiceType {Id = 1111051, Code = "11051", Name = "Введение гормона в халязион"},
                    new ServiceType {Id = 1111128, Code = "11128", Name = "Тест 6 - ти минутной ходьбы"},
                    new ServiceType
                    {
                        Id = 1206322,
                        Code = "11154",
                        Name = "Ультразвуковая допплерография сосудов мошонки и полового члена"
                    },
                    new ServiceType
                    {
                        Id = 1112001,
                        Code = "12001",
                        Name =
                            "Проведение блокады с применением  местных анастетиков:                                                                                      I степени сложности (инфильтрационная, проводниковая)"
                    },
                    new ServiceType {Id = 1112025, Code = "12025", Name = "Перевязка в чистой перевязочной"},
                    new ServiceType {Id = 1116011, Code = "16011", Name = "Определение LE - клеток"},
                    new ServiceType
                    {
                        Id = 1122001,
                        Code = "22001",
                        Name = "Прием (осмотр, консультация) врача стоматолога-хирурга"
                    },
                    new ServiceType {Id = 1122030, Code = "22030", Name = "Снятие шин с одной челюсти"},
                    new ServiceType
                    {
                        Id = 1122053,
                        Code = "22053",
                        Name = "Коррекция верхнечелюстного и нижнечелюстного переломов (шинирование)"
                    },
                    new ServiceType {Id = 1116501, Code = "16501", Name = "Эритроциты"},
                    new ServiceType {Id = 1116505, Code = "16505", Name = "MCV"},
                    new ServiceType {Id = 1116512, Code = "16512", Name = "Метамиелоциты (юные)"},
                    new ServiceType {Id = 1116609, Code = "16609", Name = "Эритроциты"},
                    new ServiceType {Id = 1116883, Code = "16883", Name = "Пунктаты"},
                    new ServiceType {Id = 1202024, Code = "", Name = "Лабораторные исследования"},
                    new ServiceType {Id = 1204021, Code = "", Name = "Прочие иммунологические исследования"},
                    new ServiceType {Id = 1203110, Code = "", Name = "ЛОР"},
                    new ServiceType
                    {
                        Id = 1118105,
                        Code = "18105",
                        Name = "Экстренное МСКТ исследование дополнительно к стоимости исследования"
                    },
                    new ServiceType
                    {
                        Id = 1206320,
                        Code = "11152",
                        Name =
                            "Дуплексное сканирование нижней полой вены и ее висцеральных ветвей (почечных, печеночных)"
                    },
                    new ServiceType
                    {
                        Id = 1123092,
                        Code = "23092",
                        Name = "Снятие цельнолитой коронки, металлокерамической"
                    },
                    new ServiceType {Id = 1206331, Code = "16195", Name = "Исследование уровня железа сыворотки крови"},
                    new ServiceType
                    {
                        Id = 1206337,
                        Code = "16197",
                        Name = "Исследование уровня холестерина липопротеидов высокой плотности"
                    },
                    new ServiceType
                    {
                        Id = 1123062,
                        Code = "23062",
                        Name = "Бюгельные протезы: Дуга бюгельная на верхнюю челюсть с креплением на кламмерах"
                    },
                    new ServiceType
                    {
                        Id = 1206499,
                        Code = "18132",
                        Name = "МСКТ органов брюшной полости  с внутривенным контрастированием"
                    },
                    new ServiceType
                    {
                        Id = 1125011,
                        Code = "25011",
                        Name = "Медицинский осмотр декретированного населения (санитарная книжка) - женщины"
                    },
                    new ServiceType
                    {
                        Id = 1125034,
                        Code = "25034",
                        Name = "Исследование уровня общего билирубина в крови"
                    },
                    new ServiceType {Id = 1125055, Code = "25055", Name = "Общий анализ мочи с микроскопией"},
                    new ServiceType {Id = 1206162, Code = "", Name = "Функциональная диагностика (эндокринолог)"},
                    new ServiceType {Id = 1117109, Code = "17109", Name = "РНК гепатита С п/количественный (Амплисенс)"},
                    new ServiceType {Id = 1125065, Code = "25065", Name = "Определение антител к гепатиту С"},
                    new ServiceType {Id = 1206304, Code = "16188", Name = "Определение РАРР"},
                    new ServiceType
                    {
                        Id = 1206307,
                        Code = "16191",
                        Name = "Микроскопическое исследование уретрального отделяемого и сока простаты"
                    },
                    new ServiceType
                    {
                        Id = 1206347,
                        Code = "22059",
                        Name = "Операция удаления ретинированного зуба под инъекционной анестезией"
                    },
                    new ServiceType
                    {
                        Id = 1206354,
                        Code = "25073",
                        Name = "Профилактический прием (осмотр, консультация) врача-эндокринолога"
                    },
                    new ServiceType {Id = 1116033, Code = "16033", Name = "Определений белковых фракций"},
                    new ServiceType {Id = 1219508, Code = "", Name = "INVITRO"},
                    new ServiceType {Id = 1116049, Code = "16049", Name = "Триглицериды"},
                    new ServiceType {Id = 1218566, Code = "", Name = "VIP-ОБСЛЕДОВАНИЯ"},
                    new ServiceType {Id = 1218567, Code = "", Name = "АЛЛЕРГОЛОГИЯ"},
                    new ServiceType {Id = 1218568, Code = "", Name = "АНТИСПЕРМАЛЬНЫЕ АНТИТЕЛА"},
                    new ServiceType {Id = 1218569, Code = "", Name = "БИОХИМИЧЕСКИЕ ИССЛЕДОВАНИЯ INVITRO"},
                    new ServiceType {Id = 1218570, Code = "", Name = "БОЛЕЗНИ ЖЕЛУДОЧНО-КИШЕЧНОГО ТРАКТА"},
                    new ServiceType {Id = 1218571, Code = "", Name = "БОЛЕЗНИ СЕРДЦА И СОСУДОВ"},
                    new ServiceType {Id = 1218572, Code = "", Name = "БОЛЕЗНИ ЦЕНТРАЛЬНОЙ НЕРВНОЙ СИСТЕМЫ"},
                    new ServiceType {Id = 1218573, Code = "", Name = "ГАСТРОПАНЕЛЬ"},
                    new ServiceType {Id = 1218574, Code = "", Name = "ГИНЕКОЛОГИЯ, РЕПРОДУКЦИЯ"},
                    new ServiceType {Id = 1218575, Code = "", Name = "ГИСТОЛОГИЧЕСКИЕ ИССЛЕДОВАНИЯ INVITRO"},
                    new ServiceType {Id = 1218576, Code = "", Name = "ГОРМОНАЛЬНЫЕ ИССЛЕДОВАНИЯ"},
                    new ServiceType {Id = 1218577, Code = "", Name = "ДИАГНОСТИКА АНТИФОСФОЛИПИДНОГО СИНДРОМА (АФС)"},
                    new ServiceType {Id = 1218578, Code = "", Name = "ДИАГНОСТИКА ЗАБОЛЕВАНИЙ СОЕДИНИТЕЛЬНОЙ ТКАНИ"},
                    new ServiceType {Id = 1218579, Code = "", Name = "ДИАГНОСТИКА САХАРНОГО ДИАБЕТА"},
                    new ServiceType {Id = 1218580, Code = "", Name = "ДИАГНОСТИКА СОСТОЯНИЯ ЖЕЛУДОЧНО-КИШЕЧНОГО ТРАКТА"},
                    new ServiceType
                    {
                        Id = 1218581,
                        Code = "",
                        Name = "ДИАГНОСТИКА СОСТОЯНИЯ ПОЧЕК И МОЧЕПОЛОВОЙ СИСТЕМЫ"
                    },
                    new ServiceType {Id = 1218582, Code = "", Name = "ДРУГИЕ УСЛУГИ"},
                    new ServiceType {Id = 1218583, Code = "", Name = "ЗАБОЛЕВАНИЯ, ПЕРЕДАЮЩИЕСЯ ПОЛОВЫМ ПУТЕМ (ЗППП)"},
                    new ServiceType {Id = 1218584, Code = "", Name = "ЗДОРОВЫЙ РЕБЕНОК: ДЛЯ ДЕТЕЙ ОТ 0 ДО 14 ЛЕТ"},
                    new ServiceType {Id = 1218585, Code = "", Name = "ИММУНОГЕМАТОЛОГИЯ"},
                    new ServiceType {Id = 1218586, Code = "", Name = "ИММУНОЛОГИЧЕСКИЕ ИССЛЕДОВАНИЯ INVITRO"},
                    new ServiceType {Id = 1218588, Code = "", Name = "ИССЛЕДОВАНИЕ ПРОДУКТОВ ПИТАНИЯ"},
                    new ServiceType {Id = 1116079, Code = "16079", Name = "Исследование на возбудителей дифтерии"},
                    new ServiceType {Id = 1116069, Code = "16069", Name = "Агрегация тромбоцитов"},
                    new ServiceType
                    {
                        Id = 1123110,
                        Code = "23110",
                        Name = "Съемные протезы пластмассовые: Зуб восемь (частичный. съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123111,
                        Code = "23111",
                        Name = "Съемные протезы пластмассовые: Зуб девять (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1123122,
                        Code = "23122",
                        Name = "Гарнитур зубов импортный (спофадент) на один съемный протез"
                    },
                    new ServiceType
                    {
                        Id = 1125015,
                        Code = "25015",
                        Name = "Медицинский осмотр с оформлением справки формы № 086-у"
                    },
                    new ServiceType {Id = 1125022, Code = "25022", Name = "Флюорография легких (одна проекция)"},
                    new ServiceType
                    {
                        Id = 1125046,
                        Code = "25046",
                        Name = "Взятие мазка на Gn вне приема врача (мужчины)"
                    },
                    new ServiceType {Id = 1118092, Code = "18092", Name = "Срочное описание рентгенисследований"},
                    new ServiceType {Id = 1121002, Code = "21002", Name = "Покрытие одного зуба фиссуритом"},
                    new ServiceType
                    {
                        Id = 1121005,
                        Code = "21005",
                        Name = "Анестезия одного зуба (инъекционная анестезия)"
                    },
                    new ServiceType
                    {
                        Id = 1121008,
                        Code = "21008",
                        Name = "Устранение дефекта пломбы светоотверждаемым материалом"
                    },
                    new ServiceType
                    {
                        Id = 1121014,
                        Code = "21014",
                        Name = "Пломбирование канала пастой + гуттаперчивый штифт"
                    },
                    new ServiceType {Id = 1121015, Code = "21015", Name = "Пломбирование канала с анкерным штифтом"},
                    new ServiceType {Id = 1121034, Code = "21034", Name = "Аппликационная анестезия"},
                    new ServiceType
                    {
                        Id = 1121038,
                        Code = "21038",
                        Name = "Применение реминерализующих препаратов у одного зуба: Флюоколь"
                    },
                    new ServiceType
                    {
                        Id = 1121043,
                        Code = "21043",
                        Name = "Открытый кюретаж при болезнях пародонта в области двух зубов"
                    },
                    new ServiceType
                    {
                        Id = 1121058,
                        Code = "21058",
                        Name =
                            "Ультразвуковое удаление наддесневых и поддесневых зубных отложений (в области одного зуба)"
                    },
                    new ServiceType
                    {
                        Id = 1121059,
                        Code = "21059",
                        Name = "Пломбирование корневого канала (латеральная конденсация)"
                    },
                    new ServiceType
                    {
                        Id = 1122019,
                        Code = "22019",
                        Name = "Операция иссечения доброкачественного образования полости рта"
                    },
                    new ServiceType
                    {
                        Id = 1122022,
                        Code = "22022",
                        Name = "Операция иссечение капюшона  при лечении перикоронарита"
                    },
                    new ServiceType
                    {
                        Id = 1122035,
                        Code = "22035",
                        Name = "Остановка луночного кровотечения методом ушивания"
                    },
                    new ServiceType
                    {
                        Id = 1125041,
                        Code = "25041",
                        Name = "Общий (клинический) анализ крови (аппаратный)"
                    },
                    new ServiceType
                    {
                        Id = 1125044,
                        Code = "25044",
                        Name =
                            "Микроскопическое исследование отпечатков с поверхности перианальных складок на яйца остриц"
                    },
                    new ServiceType
                    {
                        Id = 1206519,
                        Code = "24013",
                        Name = "Законченный случай лечения в дневном стационаре"
                    },
                    new ServiceType {Id = 1121062, Code = "21062", Name = "Восстановление зуба более 1/2"},
                    new ServiceType
                    {
                        Id = 1123131,
                        Code = "23131",
                        Name = "Вкладка - Никель хромовый сплав <МЕАИоу> (Италия)"
                    },
                    new ServiceType {Id = 1123133, Code = "23133", Name = "Вкладка - Нержавеющая сталь (Россия)"},
                    new ServiceType
                    {
                        Id = 1123138,
                        Code = "23138",
                        Name = "Седло - Кобальта хромовый сплав. <UGIN DENTAIRE> (Франция)"
                    },
                    new ServiceType
                    {
                        Id = 1206539,
                        Code = "25075",
                        Name =
                            "Бактериологическое исследование слизи и пленок с миндалин на палочку дифтерии (Corinebacterium diphtheriae)"
                    },
                    new ServiceType {Id = 1206559, Code = "23145", Name = "Изготовление вкладки из композита"},
                    new ServiceType
                    {
                        Id = 1206579,
                        Code = "11163",
                        Name = "Прием (консультация) клинического фармаколога"
                    },
                    new ServiceType {Id = 1203070, Code = "", Name = "Барокамера"},
                    new ServiceType {Id = 1203100, Code = "", Name = "Урология"},
                    new ServiceType {Id = 1202001, Code = "", Name = "Прочие услуги"},
                    new ServiceType {Id = 1205010, Code = "", Name = "Невролог"},
                    new ServiceType {Id = 1205012, Code = "", Name = "R-исследования (невролог)"},
                    new ServiceType {Id = 1205024, Code = "", Name = "Функциональная диагностика (кардиолог)"},
                    new ServiceType {Id = 1118094, Code = "18094", Name = "МСКТ органов грудной полости"},
                    new ServiceType {Id = 1118095, Code = "18095", Name = "МСКТ шейного отдела позвоночника"},
                    new ServiceType {Id = 1118097, Code = "18097", Name = "МСКТ поясничного отдела позвоночника"},
                    new ServiceType {Id = 1116071, Code = "16071", Name = "Анализ крови на АФС"},
                    new ServiceType {Id = 1116076, Code = "16076", Name = "Исследование на микрофлору"},
                    new ServiceType {Id = 1116092, Code = "16092", Name = "Исследование на хеликобактер"},
                    new ServiceType {Id = 1116126, Code = "16126", Name = "Прогестерон"},
                    new ServiceType {Id = 1116131, Code = "16131", Name = "Эстрадиол"},
                    new ServiceType {Id = 1116142, Code = "16142", Name = "ПСА общий"},
                    new ServiceType
                    {
                        Id = 1111006,
                        Code = "11006",
                        Name = "Регистрация электрокардиограммы с расшифровкой"
                    },
                    new ServiceType {Id = 1111037, Code = "11037", Name = "Инъекции под коньюктиву"},
                    new ServiceType
                    {
                        Id = 1111064,
                        Code = "11064",
                        Name =
                            "Комплексное ультразвуковое исследование органов брюшной полости с исследованием кровотока объмных образований"
                    },
                    new ServiceType
                    {
                        Id = 1111083,
                        Code = "11083",
                        Name = "Ультразвуковое исследование молочных желез   при пункционной биопси"
                    },
                    new ServiceType {Id = 1111095, Code = "11095", Name = "Ректороманоскопия"},
                    new ServiceType
                    {
                        Id = 1206313,
                        Code = "11161",
                        Name = "Школа для больных с  ишемической болезнью сердца"
                    },
                    new ServiceType
                    {
                        Id = 1112057,
                        Code = "12057",
                        Name = "Зондирование слезно-носового канала с интубацией ПХВТ"
                    },
                    new ServiceType {Id = 1112068, Code = "12068", Name = "Удаление халязиона"},
                    new ServiceType
                    {
                        Id = 1114008,
                        Code = "14008",
                        Name = "НУЗ-терапия:1 сеанс промывания с озвучиванием"
                    },
                    new ServiceType {Id = 1114032, Code = "14032", Name = "Репозиция костей носа (с анестезией)"},
                    new ServiceType {Id = 1115011, Code = "15011", Name = "Раздельное диагностическое выскабливание"},
                    new ServiceType {Id = 1115017, Code = "15017", Name = "Биопсия аппаратом \"Сургитрон\""},
                    new ServiceType {Id = 1115021, Code = "15021", Name = "Вскрытие абсцесса женских половых органов"},
                    new ServiceType {Id = 1123135, Code = "23135", Name = "Дублирование модели - Силикон."},
                    new ServiceType
                    {
                        Id = 1123141,
                        Code = "23141",
                        Name =
                            "Литой базис (на дублирующей модели) - Кобальть хромовый сплав. <UGIN DENTAIRE> (Франция)"
                    },
                    new ServiceType
                    {
                        Id = 1125004,
                        Code = "25004",
                        Name = "Профилактический прием (осмотр, консультация) врача - хирурга"
                    },
                    new ServiceType {Id = 1121028, Code = "21028", Name = "Медикаментозная обработка канала"},
                    new ServiceType {Id = 1118060, Code = "18060", Name = "Томография легких"},
                    new ServiceType {Id = 1116047, Code = "16047", Name = "Холестерин (общ.)"},
                    new ServiceType {Id = 1116063, Code = "16063", Name = "Мочевая кислота"},
                    new ServiceType {Id = 1121025, Code = "21025", Name = "Распломбирование канала"},
                    new ServiceType
                    {
                        Id = 1121055,
                        Code = "21055",
                        Name = "Лоскутная операция в полости рта в области  двух зубов"
                    },
                    new ServiceType {Id = 1121057, Code = "21057", Name = "Гингивэктомия"},
                    new ServiceType {Id = 1116045, Code = "16045", Name = "АСЛ \"О\""},
                    new ServiceType {Id = 1116702, Code = "16702", Name = "Эпителий"},
                    new ServiceType {Id = 1118004, Code = "18004", Name = "Рентгеноскопия желудка"},
                    new ServiceType
                    {
                        Id = 1118006,
                        Code = "18006",
                        Name = "Рентгеноскопия желудка и 12-перстной кишки, в условиях гипотонии (дуоденография)"
                    },
                    new ServiceType
                    {
                        Id = 1125010,
                        Code = "25010",
                        Name = "Предварительный и периодический медицинский осмотр (при устройстве на работу-мужчины)"
                    },
                    new ServiceType {Id = 1110012, Code = "10012", Name = "Прием на дому"},
                    new ServiceType {Id = 1123139, Code = "23139", Name = "Кламмер - Нержавеющая сталь (Россия)"},
                    new ServiceType {Id = 1111101, Code = "11101", Name = "Ультразвуковое исследование мочевого пузыря"},
                    new ServiceType
                    {
                        Id = 1114010,
                        Code = "14010",
                        Name = "НУЗ-деструкция: носовых раковин-односторонняя"
                    },
                    new ServiceType {Id = 1115028, Code = "15028", Name = "Кардиотокография плода"},
                    new ServiceType
                    {
                        Id = 1218631,
                        Code = "40453",
                        Name =
                            "Посев на листериоз и чувствительность к антибиотикам (Listeria monocytogenes Culture. Bacteria Identification and Susceptibility) (отделяемое половых органов)"
                    },
                    new ServiceType
                    {
                        Id = 1218632,
                        Code = "40456",
                        Name = "Дисбактериоз кинечника (Stool Culture, quantitative. Intestinal bacteriel overgrowth)"
                    },
                    new ServiceType
                    {
                        Id = 1218633,
                        Code = "40457",
                        Name =
                            "Посев на дизентерийную группу и чувствительность к антибиотикам Stool Culture, Salmonella sp., Shigella sp. Bacteria Identification and Susceptibility) кал"
                    },
                    new ServiceType
                    {
                        Id = 1218634,
                        Code = "40458",
                        Name =
                            "Посев на E.Coli O157:H7 и чувствительность к антибиотикам (E.Coli O157:H7 Culture. Bacteria Identification and Susceptibility) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218635,
                        Code = "40459",
                        Name =
                            "Посев на золотистый стафилококк и чувствительность к антибиотикам (Staphylococcus aures Culture. Bacteria Identification and Susceptibility) **(кал,зев, нос, пазухи)"
                    },
                    new ServiceType
                    {
                        Id = 1218636,
                        Code = "40460",
                        Name =
                            "Посев на иерсинии и чувствительность к антибиотикам ( Stool Culture, Yersinia enterocolitica. Bacteria Identification and Susceptibility) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218637,
                        Code = "40461",
                        Name =
                            "Посев на кампилобактер (Stool Culture, Campylobacter sp. Bacterial identification) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218638,
                        Code = "40462",
                        Name =
                            "Посев на Clostridium difficile и чувствительность к антибиотикам (Clostridium difficile Culture. Bacteria Identification and Susceptibility ) (кал,желчь)"
                    },
                    new ServiceType
                    {
                        Id = 1218639,
                        Code = "40464",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Breast milk Culture, Routine. Aerobic Bacteria Identification and Susceptibility), (грудное молоко) **"
                    },
                    new ServiceType
                    {
                        Id = 1218640,
                        Code = "40465",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Eye Culture, Routine. Aerobic Bacteria Identification and Susceptibility), (отделяемое глаза)"
                    },
                    new ServiceType
                    {
                        Id = 1218641,
                        Code = "40467",
                        Name = "Посев на флору и чувствительность к антибиотикам (Upper Respiratory Culture, Routine),"
                    },
                    new ServiceType
                    {
                        Id = 1218642,
                        Code = "40469",
                        Name = "Посев на дифтерию (Corynebacterium Diphtheriae Culture) (зев, нос, пазухи)"
                    },
                    new ServiceType
                    {
                        Id = 1218643,
                        Code = "40473",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Ear culture, Routine. Aerobic Bacteria Identification and Susceptibility), (отделяемое уха)"
                    },
                    new ServiceType
                    {
                        Id = 1218644,
                        Code = "40474",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Wound/ pus/ aspirate Culture. Aerobic Bacteria Identification and Susceptibility), (гной, отделяемое ран) ** (гной, отделяемое ран)"
                    },
                    new ServiceType
                    {
                        Id = 1218645,
                        Code = "40477",
                        Name =
                            "Посев пункционной или аспирационной жидкостей на микрофлору (Body Fluid Culture, Sterile, Routine. Aerobic Bacteria Identification and Susceptibility) (пункционная жидкость)"
                    },
                    new ServiceType
                    {
                        Id = 1218646,
                        Code = "40478",
                        Name =
                            "Расширенная антибиотикограмма по клиническим показаниям (Susceptibility Testing, Aerobic Bacteria (enlarged)"
                    },
                    new ServiceType
                    {
                        Id = 1218647,
                        Code = "40481",
                        Name = "Аденовирус, антиген (Adenovirus, antigen) (кал, зев)"
                    },
                    new ServiceType
                    {
                        Id = 1218648,
                        Code = "40482",
                        Name = "Криптоспоридии парвум, антиген (Cryptosporidium parvum, antigen) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218649,
                        Code = "40483",
                        Name = "Лямблии, антиген (Giardia Liamblia, antigen) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218650,
                        Code = "40484",
                        Name = "Хеликобактер пилори, антиген (H. pylori, antigen) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218651,
                        Code = "40485",
                        Name = "E. coli O157:H7, антиген (E. coli O 157:H7, antigen) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218652,
                        Code = "40486",
                        Name = "Токсин A Clostridium difficile (Toxin A Clostridium difficile) (кал)"
                    },
                    new ServiceType
                    {
                        Id = 1218653,
                        Code = "40487",
                        Name = "Стрептококк группы А, антиген (Strep A, antigen) (зев)"
                    },
                    new ServiceType
                    {
                        Id = 1218654,
                        Code = "40488",
                        Name = "Стрептококк группы В, антиген (Strep В, antigen) (отделяемое половых органов)"
                    },
                    new ServiceType
                    {
                        Id = 1218655,
                        Code = "40489",
                        Name =
                            "Influenza A+B, антигены (Influenza A+B, antigen) (мазок слизи или смывы из носовых ходов)"
                    },
                    new ServiceType
                    {
                        Id = 1218656,
                        Code = "40500",
                        Name =
                            "Цитологическое исследование материала, полученного при хирургических вмешательствах и других срочных исследованиях"
                    },
                    new ServiceType
                    {
                        Id = 1218657,
                        Code = "40502",
                        Name =
                            "Исследование соскобов и отпечатков с поверхности кожи и слизистых (В медицинских офисах ИНВИТРО)"
                    },
                    new ServiceType
                    {
                        Id = 1218658,
                        Code = "40503",
                        Name = "Исследование соскобов и отпечатков опухолей и опухолевоподобных заболеваний"
                    },
                    new ServiceType {Id = 1218659, Code = "40504", Name = "Исследование эндоскопического материала"},
                    new ServiceType
                    {
                        Id = 1218660,
                        Code = "40505",
                        Name = "Исследование соскобов шейки матки и цервикального канала (В медицинских офисах ИНВИТРО)"
                    },
                    new ServiceType {Id = 1218661, Code = "40506", Name = "Исследование аспиратов из полости матки"},
                    new ServiceType
                    {
                        Id = 1218662,
                        Code = "40507",
                        Name = "Исследование транссудатов, экссудатов, секретов, экскретов"
                    },
                    new ServiceType {Id = 1218663, Code = "40508", Name = "Исследование мокроты"},
                    new ServiceType
                    {
                        Id = 1218664,
                        Code = "40509",
                        Name = "Исследование пунктатов молочной железы и кожи"
                    },
                    new ServiceType
                    {
                        Id = 1218665,
                        Code = "40510",
                        Name = "Исследование пунктатов других органов и тканей"
                    },
                    new ServiceType
                    {
                        Id = 1218666,
                        Code = "40511",
                        Name =
                            "Исследование биопсийного материала (эндоскопического материала; тканей женской половой системы; кожи, мягких тканей; кроветворной и лимфоидной ткани; костно-хрящевой ткани)"
                    },
                    new ServiceType
                    {
                        Id = 1218667,
                        Code = "40514",
                        Name = "Исследование эндоскопического материала  на наличие  Helicobacter pylori"
                    },
                    new ServiceType
                    {
                        Id = 1218668,
                        Code = "40516",
                        Name = "Гистохимическое исследование: - Helicobacter pylori; - слизь"
                    },
                    new ServiceType {Id = 1116106, Code = "16106", Name = "Тест толерантности к глюкозе"},
                    new ServiceType {Id = 1116132, Code = "16132", Name = "Антитела к пероксидазе тиреоцитов"},
                    new ServiceType {Id = 1116170, Code = "16170", Name = "С-пептид"},
                    new ServiceType {Id = 1114012, Code = "14012", Name = "Вскрытие паратонзилярного абсцесса"},
                    new ServiceType {Id = 1115009, Code = "15009", Name = "Удаление внутриматочной спирали"},
                    new ServiceType {Id = 1115014, Code = "15014", Name = "Микроклизмирование влагалища"},
                    new ServiceType {Id = 1122014, Code = "22014", Name = "Лечение альвеолита с кюретажем лунки"},
                    new ServiceType
                    {
                        Id = 1122032,
                        Code = "22032",
                        Name = "Вправление сложного вывиха височно - нижнечелюстного сустава"
                    },
                    new ServiceType
                    {
                        Id = 1123054,
                        Code = "23054",
                        Name = "Реставрация съемного протеза после удаления одного зуба, приварка одного зуба"
                    },
                    new ServiceType
                    {
                        Id = 1123067,
                        Code = "23067",
                        Name = "Бюгельные протезы: Кламмер опорно-удерживающий"
                    },
                    new ServiceType {Id = 1111003, Code = "11003", Name = "Школа для больных сахарным диабетом"},
                    new ServiceType
                    {
                        Id = 1123075,
                        Code = "23075",
                        Name = "Фарфор и металлокерамика: Изготовление модели разборной из супергипса"
                    },
                    new ServiceType
                    {
                        Id = 1111018,
                        Code = "11018",
                        Name = "Внутривенное  капельное вливание лекарственных средств"
                    },
                    new ServiceType
                    {
                        Id = 1111056,
                        Code = "11056",
                        Name = "Ультразвуковая допплерография брюшного отдела аорты и подвздошных артерий"
                    },
                    new ServiceType
                    {
                        Id = 1111068,
                        Code = "11068",
                        Name =
                            "Ультразвуковое исследование матки и придатков с исследованием кровотока объемных образований"
                    },
                    new ServiceType {Id = 1111081, Code = "11081", Name = "Ультразвуковое исследование молочных желез"},
                    new ServiceType
                    {
                        Id = 1111086,
                        Code = "11086",
                        Name =
                            "Ультразвуковое исследование мягких тканей  с исследованием кровотока объемных образований"
                    },
                    new ServiceType
                    {
                        Id = 1111127,
                        Code = "11127",
                        Name = "Суточное мониторирование  артериального давления"
                    },
                    new ServiceType
                    {
                        Id = 1118039,
                        Code = "18039",
                        Name = "Рентгенография височно-нижнечелюстного сустава (2 проекции)"
                    },
                    new ServiceType {Id = 1111055, Code = "11055", Name = "Дуплексное сканирование артерий шеи"},
                    new ServiceType {Id = 1116516, Code = "16516", Name = "Моноциты (Мн)"},
                    new ServiceType
                    {
                        Id = 1115008,
                        Code = "15008",
                        Name = "Введение внутриматочной спирали (без стоимости контрацептива)"
                    },
                    new ServiceType {Id = 1202021, Code = "", Name = "Гематологические исследования"},
                    new ServiceType {Id = 1118121, Code = "18121", Name = "Рентгенография грудины (1 проекция)"},
                    new ServiceType {Id = 1125890, Code = "25890", Name = "Гематологические исследования"},
                    new ServiceType {Id = 1204018, Code = "", Name = "Репродуктивные гормоны"},
                    new ServiceType {Id = 1203060, Code = "", Name = "Томография"},
                    new ServiceType {Id = 1205000, Code = "", Name = "По специальностям"},
                    new ServiceType {Id = 1205023, Code = "", Name = "Флюорисследования (кардиолог)"},
                    new ServiceType {Id = 1123028, Code = "23028", Name = "Армирование протеза, вваривание"},
                    new ServiceType
                    {
                        Id = 1123142,
                        Code = "23142",
                        Name = "Разборная вкладка - Никель хромовый сплав <МЕАИоу> (Италия)"
                    },
                    new ServiceType
                    {
                        Id = 1115019,
                        Code = "15019",
                        Name =
                            "Удаление доброкачественных новообразований влагалища и вульвы (одного)аппаратом \"Сургитрон\""
                    },
                    new ServiceType {Id = 1118021, Code = "18021", Name = "Рентгенография кистей рук (сравнительно)"},
                    new ServiceType {Id = 1118030, Code = "18030", Name = "Рентгенография ребра (1 проекция)"},
                    new ServiceType
                    {
                        Id = 1118043,
                        Code = "18043",
                        Name = "Рентгенография пяточной кости (двух проекции)"
                    },
                    new ServiceType
                    {
                        Id = 1118056,
                        Code = "18056",
                        Name = "Рентгенография височных костей (сравнительно): по Майеру"
                    },
                    new ServiceType {Id = 1123059, Code = "23059", Name = "Приварка двух кламмеров"},
                    new ServiceType {Id = 1123080, Code = "23080", Name = "Бюгельные протезы: Модель комбинированная"},
                    new ServiceType
                    {
                        Id = 1114001,
                        Code = "14001",
                        Name = "Внутриносовые, глоточные блокады ЛОР-органов"
                    },
                    new ServiceType
                    {
                        Id = 1118113,
                        Code = "18113",
                        Name = "МСКТ ангиография грудного отдела аорты с болюсным контрастированием"
                    },
                    new ServiceType {Id = 1119018, Code = "19018", Name = "Магнитотерапия"},
                    new ServiceType
                    {
                        Id = 1114029,
                        Code = "14029",
                        Name = "Механическая остановка кровотечения (передняя тампонада носа)"
                    },
                    new ServiceType
                    {
                        Id = 1119028,
                        Code = "19028",
                        Name = "Ультразвуковое лечение с использованием лекарственных ср - в (ФОНОФОРЕЗ)"
                    },
                    new ServiceType {Id = 1113009, Code = "13009", Name = "Бужирование уретры"},
                    new ServiceType
                    {
                        Id = 1123113,
                        Code = "23113",
                        Name = "Съемные протезы пластмассовые: Зуб одиннадцать (частичный, съемный)"
                    },
                    new ServiceType
                    {
                        Id = 1125003,
                        Code = "25003",
                        Name = "Профилактический прием (осмотр, консультация) врача-дерматовенеролога"
                    },
                    new ServiceType
                    {
                        Id = 1125009,
                        Code = "25009",
                        Name = "Предварительный и периодический медицинский осмотр (при устройстве на работу-женщины)"
                    },
                    new ServiceType
                    {
                        Id = 1125037,
                        Code = "25037",
                        Name = "Бактериологическое исследование на кишечные инфекции"
                    },
                    new ServiceType {Id = 1218617, Code = "", Name = "ТРОМБОФИЛИИ"},
                    new ServiceType {Id = 1218618, Code = "", Name = "ЦИРКУЛИРУЮЩИЕ ИММУННЫЕ КОМПЛЕКСЫ (ЦИК)"},
                    new ServiceType {Id = 1218619, Code = "", Name = "ЦИТОЛОГИЧЕСКИЕ ИССЛЕДОВАНИЯ INVITRO"},
                    new ServiceType {Id = 1218620, Code = "40398", Name = "Influenza virus A/H1 - swine"},
                    new ServiceType {Id = 1218621, Code = "40401", Name = "Проба Сулковича"},
                    new ServiceType
                    {
                        Id = 1218622,
                        Code = "40438",
                        Name =
                            "Посев на аэробные и анаэробные микроорганизмы и чувствительность к антибиотикам (Blood Culture, Routine. Aerobic and Anaerobic Bacteria Identification and Susceptibility) кровь"
                    },
                    new ServiceType
                    {
                        Id = 1218623,
                        Code = "40440",
                        Name =
                            "Посев на M. hominis и чувствительность к антибиотикам (Mycoplasma hominis Culture, quantitative. Bacteria Identification and Susceptibility) ** моча (муж)"
                    },
                    new ServiceType
                    {
                        Id = 1218624,
                        Code = "40441",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Urine Culture, Routine, quantitative. Aerobic Bacteria Identification and Susceptibility), (моча)"
                    },
                    new ServiceType
                    {
                        Id = 1218625,
                        Code = "40442",
                        Name =
                            "Посев на Candida и чувствительность к антимикотическим препаратам(Yeast Culture, Candida Culture. Bacteria Identification and Susceptibility) (моча, кал, мокрота,отделяемое половых органов, зев, нос, пазухи, гной)"
                    },
                    new ServiceType {Id = 1218615, Code = "", Name = "СОВПАДЕНИЕ ПО ЛОКУСАМ HLA И РЕЗУС-ФАКТОР"},
                    new ServiceType {Id = 1218616, Code = "", Name = "СПЕЦИФИЧЕСКИЕ БЕЛКИ"},
                    new ServiceType {Id = 1218590, Code = "", Name = "КЛИНИЧЕСКИЙ АНАЛИЗ КРОВИ"},
                    new ServiceType {Id = 1218591, Code = "", Name = "ЛЕКАРСТВЕННЫЙ МОНИТОРИНГ"},
                    new ServiceType {Id = 1218592, Code = "", Name = "МАЗОК ИЗ ПОЛОСТИ НОСА И РОТОГЛОТКИ"},
                    new ServiceType {Id = 1218593, Code = "", Name = "МАРКЕРЫ АУТОИММУННЫХ ЗАБОЛЕВАНИЙ"},
                    new ServiceType {Id = 1218594, Code = "", Name = "МИКРОБИОЛОГИЯ"},
                    new ServiceType {Id = 1218595, Code = "", Name = "МИКРОЭЛЕМЕНТЫ - ПРОФИЛИ"},
                    new ServiceType {Id = 1218596, Code = "", Name = "МОКРОТА,АСПИРАТ ИЗ НОСОГЛОТКИ ИЛИ ТРАХЕИ"},
                    new ServiceType {Id = 1218597, Code = "", Name = "МОЛЕКУЛЯРНО - ГЕНЕТИЧЕСКИЕ ИССЛЕДОВАНИЯ"},
                    new ServiceType {Id = 1218598, Code = "", Name = "МОЛЕКУЛЯРНО-ГЕНЕТИЧЕСКИЕ ИССЛЕДОВАНИЯ**"},
                    new ServiceType {Id = 1218599, Code = "", Name = "НАРУШЕНИЯ ОБМЕНА ВЕЩЕСТВ"},
                    new ServiceType {Id = 1218600, Code = "", Name = "НЕОРГАНИЧЕСКИЕ ВЕЩЕСТВА (МИКРОЭЛЕМЕНТЫ)"},
                    new ServiceType {Id = 1218601, Code = "", Name = "ОЖИРЕНИЕ"},
                    new ServiceType {Id = 1218602, Code = "", Name = "ОНКОЛОГИЧЕСКИЕ ЗАБОЛЕВАНИЯ"},
                    new ServiceType {Id = 1218603, Code = "", Name = "ОНКОЛОГИЯ"},
                    new ServiceType {Id = 1218604, Code = "", Name = "ОНКОМАРКЕРЫ"},
                    new ServiceType
                    {
                        Id = 1218606,
                        Code = "",
                        Name = "ОЦЕНКА РИСКА РАЗВИТИЯ ЗАБОЛЕВАНИЙ СЕРДЕЧНО-СОСУДИСТОЙ СИСТЕМЫ"
                    },
                    new ServiceType {Id = 1218607, Code = "", Name = "ОЦЕНКА ФУНКЦИИ ПЕЧЕНИ"},
                    new ServiceType {Id = 1218608, Code = "", Name = "ПРОБЛЕМЫ ВЕСА"},
                    new ServiceType {Id = 1218609, Code = "", Name = "ПРОТОЗОЙНЫЕ И ПАРАЗИТАРНЫЕ ИНФЕКЦИИ"},
                    new ServiceType {Id = 1218610, Code = "", Name = "ПРОФИЛИ ИССЛЕДОВАНИЙ"},
                    new ServiceType {Id = 1218611, Code = "", Name = "РЕПРОДУКТИВНОЕ ЗДОРОВЬЕ ЖЕНЩИНЫ"},
                    new ServiceType {Id = 1218612, Code = "", Name = "РЕПРОДУКТИВНОЕ ЗДОРОВЬЕ МУЖЧИНЫ"},
                    new ServiceType {Id = 1218613, Code = "", Name = "СИМПАТО-АДРЕНАЛОВАЯ СИСТЕМА"},
                    new ServiceType
                    {
                        Id = 1218614,
                        Code = "",
                        Name = "СИСТЕМА ДЕТОКСИКАЦИИ КСЕНОБИОТИКОВ И КАНЦЕРОГЕНОВ"
                    },
                    new ServiceType {Id = 1116701, Code = "16701", Name = "Гонококк"},
                    new ServiceType {Id = 1125880, Code = "25880", Name = "Биохимический анализ крови"},
                    new ServiceType {Id = 1116878, Code = "16878", Name = "Эякулят"},
                    new ServiceType {Id = 1204012, Code = "", Name = "Кардиомаркеры"},
                    new ServiceType {Id = 1204019, Code = "", Name = "Онкомаркеры"},
                    new ServiceType {Id = 1203010, Code = "", Name = "Терапия"},
                    new ServiceType {Id = 1203041, Code = "", Name = "Рентгенография"},
                    new ServiceType {Id = 1116074, Code = "16074", Name = "Определение титр-антител"},
                    new ServiceType
                    {
                        Id = 1116089,
                        Code = "16089",
                        Name = "Определение чувствительности урогенитальных микоплазм к антибиотикам"
                    },
                    new ServiceType {Id = 1118081, Code = "18081", Name = "Ортопантомография с распечаткой снимков"},
                    new ServiceType {Id = 1110002, Code = "10002", Name = "Прием (осмотр, консультация) КМН"},
                    new ServiceType {Id = 1111017, Code = "11017", Name = "Внутривенное введение лекарственных средств"},
                    new ServiceType {Id = 1111028, Code = "11028", Name = "Криодеструкция остроконечных кондилом"},
                    new ServiceType {Id = 1111043, Code = "11043", Name = "Электростимуляция (1 сеанс)"},
                    new ServiceType
                    {
                        Id = 1111059,
                        Code = "11059",
                        Name = "Дуплексное сканирование артерий верхней  конечности"
                    },
                    new ServiceType
                    {
                        Id = 1111073,
                        Code = "11073",
                        Name = "Ультразвуковое исследование органов матки и придатков во 2 и 3 триместрах  беременности"
                    },
                    new ServiceType {Id = 1116179, Code = "16179", Name = "HCV (исследование на вирусный гепатит С)"},
                    new ServiceType {Id = 1111131, Code = "11131", Name = "Рефрактометрия"},
                    new ServiceType {Id = 1111143, Code = "11143", Name = "Ультразвуковое исследование полового члена"},
                    new ServiceType {Id = 1118012, Code = "18012", Name = "Рентгенография черепа в двух проекциях"},
                    new ServiceType
                    {
                        Id = 1118022,
                        Code = "18022",
                        Name = "Рентгенография коленного сустава (2 проекции)"
                    },
                    new ServiceType {Id = 1118031, Code = "18031", Name = "Рентгенография ребра (2 проекции)"},
                    new ServiceType {Id = 1118044, Code = "18044", Name = "Рентгенография легких (1 проекция)"},
                    new ServiceType {Id = 1118070, Code = "18070", Name = "Томография  суставов"},
                    new ServiceType
                    {
                        Id = 1118054,
                        Code = "18054",
                        Name = "Рентгенография шейного отдела позвоночника (функционально)"
                    },
                    new ServiceType
                    {
                        Id = 1118109,
                        Code = "18109",
                        Name = "МСКТ печени и её сосудов (3-х фазная ангиография)"
                    },
                    new ServiceType {Id = 1119008, Code = "19008", Name = "Диадинамотерапия"},
                    new ServiceType {Id = 1119017, Code = "19017", Name = "Микроволновая терапия"},
                    new ServiceType {Id = 1119037, Code = "19037", Name = "Ингаляторное введение лекарственных средств"},
                    new ServiceType
                    {
                        Id = 1121001,
                        Code = "21001",
                        Name = "Прием (осмотр, консультация) врача стоматолога-терапевта"
                    },
                    new ServiceType
                    {
                        Id = 1121018,
                        Code = "21018",
                        Name = "Частичная реставрация зуба светоотверждаемым материалом"
                    },
                    new ServiceType {Id = 1123095, Code = "23095", Name = "Изготовление культевой вкладки в два канала"},
                    new ServiceType
                    {
                        Id = 1123106,
                        Code = "23106",
                        Name = "Съемные протезы пластмассовые: Зуб четыре (частичный, съемный)"
                    },
                    new ServiceType {Id = 1111089, Code = "11089", Name = "Ультразвуковое исследование глазного яблока"},
                    new ServiceType
                    {
                        Id = 1218810,
                        Code = "40053",
                        Name =
                            "Трийодтиронин свободный (Т3 свободный, Free Triiodthyronine, FT3)(кровь (сыворотка)) (Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218811,
                        Code = "40054",
                        Name =
                            "Тироксин общий (T4 общий, тетрайодтиронин общий, Total Thyroxine, TT4)(кровь (сыворотка)) (Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218812,
                        Code = "40055",
                        Name = "Диагностика антифосфолипидного синдрома (АФС)"
                    },
                    new ServiceType {Id = 1218813, Code = "40056", Name = "Обследование ПЕЧЕНИ: полное"},
                    new ServiceType
                    {
                        Id = 1218814,
                        Code = "40057",
                        Name =
                            "Антитела к тиреоглобулину (АТ-ТГ, anti-thyroglobulin autoantibodies) - №57 (кровь (сыворотка))(Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218815,
                        Code = "40058",
                        Name =
                            "Антитела к тиреоидной пероксидазе (АТ-ТПО, микросомальные антитела, anti-thyroid peroxidase autoantibodies) (кровь (сыворотка))(Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218816,
                        Code = "40059",
                        Name =
                            "Фолликулостимулирующий гормон (ФСГ, Follicle stimulating hormone, FSH) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218817,
                        Code = "40060",
                        Name =
                            "Лютеинизирующий гормон (ЛГ, LH) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218818,
                        Code = "40061",
                        Name =
                            "Пролактин (Prolactin) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218626,
                        Code = "40443",
                        Name =
                            "Чувствительность к бактериофагам (Bacteriophage Susceptibility Testing) (моча, отделяемое половых органов,кал, зев,нос, пазухи,мокротоа, гной, пункционная жидкость,желчь, кровь,отделяемое уха, груднное молоко)"
                    },
                    new ServiceType
                    {
                        Id = 1218627,
                        Code = "40444",
                        Name =
                            "Посев на U. Urealyticum и чувствительность к антибиотикам (Ureaplasma urealyticum Culture, quantitative. Bacteria Identification and Susceptibility) ** моча (муж)"
                    },
                    new ServiceType
                    {
                        Id = 1218628,
                        Code = "40445",
                        Name =
                            "Микроскопическое исследование окрашенного нативного мазка - бактериоскопия (Gram's Stain. Bacterioscopic examination of different smears (vaginal, crvical, urethral, sputum, wound, etc) (зев, нос, пазухи, гной, пункционная жидкость, отделяемое половых органов,мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1218629,
                        Code = "40446",
                        Name =
                            "Посев на флору и чувствительность к антибиотикам (Genitourinary tract Culture, Routine. Aerobic Bacteria Identification and Susceptibility), (отделяемое половых органов)"
                    },
                    new ServiceType
                    {
                        Id = 1218630,
                        Code = "40447",
                        Name =
                            "Исследование на биоценоз влагалища и чувствительность к антибиотикам (с микроскопией нативного препарата) (Vaginal Culture, Routine, quantitative. Aerobic Bacteria Identification and Susceptibility) **(отделяемое половых органов)"
                    },
                    new ServiceType
                    {
                        Id = 1219005,
                        Code = "40362",
                        Name =
                            "Вирус гепатита В, определение ДНК (количественное, реагенты F. Hoffmann-La Roche) (HBV-DNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1219006,
                        Code = "40363",
                        Name = "Уреаплазма Т-960 (Ureaplasma urealiticum Т-960), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219007,
                        Code = "40364",
                        Name = "Уреаплазма (Ureaplasma parvum), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219008,
                        Code = "40365",
                        Name = "Уреаплазма (Ureaplasma spp), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219009,
                        Code = "40366",
                        Name = "Микоплазма (Mycoplasma hominis), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219010,
                        Code = "40367",
                        Name = "Микоплазма (Mycoplasma genitalium), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219011,
                        Code = "40368",
                        Name = "Mycobacterium tuberculosis (M.Tuberculosis), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219012,
                        Code = "40369",
                        Name = "Mycobacterium tuberculosis (M.Tuberculosis), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219013,
                        Code = "40370",
                        Name = "Вирус птичьего гриппа, определение РНК (качественный) (Influenza virus H5N1), (кровь)"
                    },
                    new ServiceType {Id = 1219015, Code = "40925", Name = "Опиаты - Моча"},
                    new ServiceType {Id = 1219016, Code = "40928", Name = "Витамин Д (25-ОН)"},
                    new ServiceType
                    {
                        Id = 1219017,
                        Code = "40948",
                        Name = "Эозинофильный катионовый белок (Eosinophil Cationic Protein, ECP) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219018, Code = "40965", Name = "Антитела к кератину (кровь (сыворотка))"},
                    new ServiceType
                    {
                        Id = 1219019,
                        Code = "40967",
                        Name = "АТ к кардиолипину, скрининг IgA, IgM, IgG (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219020, Code = "40968", Name = "АТ к кардиолипину IgA (кровь (сыворотка))"},
                    new ServiceType {Id = 1219022, Code = "40971", Name = "АТ к ретикулину (ARA) (кровь (сыворотка))"},
                    new ServiceType {Id = 1219023, Code = "40972", Name = "АТ к эндомизию (EMA) (кровь (сыворотка))"},
                    new ServiceType {Id = 1219024, Code = "40973", Name = "АТ к тромбоцитам (кровь (сыворотка))"},
                    new ServiceType {Id = 1219025, Code = "40980", Name = "Фенциклидин - Моча"},
                    new ServiceType {Id = 1219026, Code = "40981", Name = "Этанол (алкоголь) кровь (сыворотка)"},
                    new ServiceType {Id = 1219027, Code = "40982", Name = "Этанол (алкоголь) -Моча"},
                    new ServiceType
                    {
                        Id = 1219028,
                        Code = "40995",
                        Name = "Микроскопическое исследование проб кожи и ногтей на присутствие клеток грибов"
                    },
                    new ServiceType
                    {
                        Id = 1219029,
                        Code = "40998",
                        Name =
                            "Определение чувствительности (cпецифических IgE) к аллергену апельсина/Orange (Citrus sinensis) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType {Id = 1219030, Code = "41000", Name = "Литий (волосы)"},
                    new ServiceType {Id = 1219031, Code = "41001", Name = "Бор (волосы)"},
                    new ServiceType {Id = 1219032, Code = "41002", Name = "Натрий (волосы)"},
                    new ServiceType {Id = 1219033, Code = "41003", Name = "Магний (волосы)"},
                    new ServiceType {Id = 1219034, Code = "41004", Name = "Алюминий (волосы)"},
                    new ServiceType {Id = 1219035, Code = "41005", Name = "Кремний (волосы)"},
                    new ServiceType {Id = 1219036, Code = "41006", Name = "Калий (волосы)"},
                    new ServiceType {Id = 1219037, Code = "41007", Name = "Кальций (волосы)"},
                    new ServiceType {Id = 1219039, Code = "41009", Name = "Хром (волосы)"},
                    new ServiceType {Id = 1219040, Code = "41010", Name = "Марганец (волосы)"},
                    new ServiceType {Id = 1219041, Code = "41011", Name = "Железо (волосы)"},
                    new ServiceType {Id = 1219042, Code = "41012", Name = "Кобальт (волосы)"},
                    new ServiceType {Id = 1219043, Code = "41013", Name = "Никель (волосы)"},
                    new ServiceType {Id = 1219044, Code = "41014", Name = "Медь (волосы)"},
                    new ServiceType {Id = 1219045, Code = "41015", Name = "Цинк (волосы)"},
                    new ServiceType {Id = 1219046, Code = "41016", Name = "Мышьяк (волосы)"},
                    new ServiceType {Id = 1219047, Code = "41017", Name = "Селен (волосы)"},
                    new ServiceType {Id = 1219048, Code = "41018", Name = "Молибден (волосы)"},
                    new ServiceType {Id = 1219049, Code = "41019", Name = "Кадмий (волосы)"},
                    new ServiceType {Id = 1219051, Code = "41021", Name = "Ртуть (волосы)"},
                    new ServiceType {Id = 1219052, Code = "41022", Name = "Свинец (волосы)"},
                    new ServiceType {Id = 1219053, Code = "41032", Name = "Марганец (моча)"},
                    new ServiceType {Id = 1219054, Code = "41033", Name = "Железо (моча)"},
                    new ServiceType {Id = 1219055, Code = "41034", Name = "Кобальт (моча)"},
                    new ServiceType {Id = 1219056, Code = "41035", Name = "Медь (моча)"},
                    new ServiceType {Id = 1219059, Code = "41038", Name = "Селен (моча)"},
                    new ServiceType {Id = 1219060, Code = "41040", Name = "Кадмий (моча)"},
                    new ServiceType {Id = 1219061, Code = "41042", Name = "Ртуть (мочи)"},
                    new ServiceType
                    {
                        Id = 1219062,
                        Code = "41070",
                        Name =
                            "Определение чувствительности (cпецифических IgE) к панели аллергенов домашних грызунов: эпителий морской свинки, эпителий кролика, хомяка, крысы, мыши (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType {Id = 1219065, Code = "41075", Name = "Серебро (ногти)"},
                    new ServiceType {Id = 1219066, Code = "41076", Name = "Алюминий (ногти)"},
                    new ServiceType {Id = 1219067, Code = "41077", Name = "Мышьяк (ногти)"},
                    new ServiceType {Id = 1219068, Code = "41078", Name = "Золото (ногти)"},
                    new ServiceType {Id = 1219069, Code = "41079", Name = "Бор (ногти)"},
                    new ServiceType {Id = 1219071, Code = "41081", Name = "Бериллий (ногти)"},
                    new ServiceType {Id = 1219072, Code = "41082", Name = "Висмут (ногти)"},
                    new ServiceType {Id = 1219073, Code = "41083", Name = "Кальций (ногти)"},
                    new ServiceType {Id = 1219074, Code = "41084", Name = "Кадмий (ногти)"},
                    new ServiceType {Id = 1219075, Code = "41085", Name = "Кобальт (ногти)"},
                    new ServiceType {Id = 1219076, Code = "41086", Name = "Хром (ногти)"},
                    new ServiceType {Id = 1219077, Code = "41087", Name = "Медь (ногти)"},
                    new ServiceType {Id = 1219078, Code = "41088", Name = "Железо (ногти)"},
                    new ServiceType {Id = 1219079, Code = "41089", Name = "Галлий (ногти)"},
                    new ServiceType {Id = 1219080, Code = "41090", Name = "Германий (ногти)"},
                    new ServiceType {Id = 1219081, Code = "41091", Name = "Ртуть (ногти)"},
                    new ServiceType {Id = 1219082, Code = "41092", Name = "Йод (ногти)"},
                    new ServiceType {Id = 1219083, Code = "41093", Name = "Калий (ногти)"},
                    new ServiceType {Id = 1219084, Code = "41094", Name = "Лантан (ногти)"},
                    new ServiceType {Id = 1219085, Code = "41095", Name = "Литий (ногти)"},
                    new ServiceType {Id = 1219086, Code = "41096", Name = "Магний (ногти)"},
                    new ServiceType {Id = 1219087, Code = "41097", Name = "Марганец (ногти)"},
                    new ServiceType {Id = 1219088, Code = "41098", Name = "Молибден (ногти)"},
                    new ServiceType {Id = 1219089, Code = "41099", Name = "Натрий (ногти)"},
                    new ServiceType {Id = 1219090, Code = "41100", Name = "Никель (ногти)"},
                    new ServiceType {Id = 1219092, Code = "41102", Name = "Свинец (ногти)"},
                    new ServiceType {Id = 1219093, Code = "41103", Name = "Платина (ногти)"},
                    new ServiceType {Id = 1219094, Code = "41104", Name = "Рубидий (ногти)"},
                    new ServiceType {Id = 1219096, Code = "41106", Name = "Селен (ногти)"},
                    new ServiceType {Id = 1219097, Code = "41107", Name = "Кремний (ногти)"},
                    new ServiceType {Id = 1219099, Code = "41109", Name = "Стронций (ногти)"},
                    new ServiceType {Id = 1219100, Code = "41110", Name = "Таллий (ногти)"},
                    new ServiceType {Id = 1219101, Code = "41111", Name = "Золото - кровь"},
                    new ServiceType {Id = 1219103, Code = "41113", Name = "Кобальт - цельная кровь"},
                    new ServiceType {Id = 1219104, Code = "41114", Name = "Медь - цельная кровь"},
                    new ServiceType
                    {
                        Id = 1218669,
                        Code = "40519",
                        Name =
                            "Цитологическое исследование биоматериала различных локализаций, кроме шейки матки (окрашивание по Папаниколау, Рар-тест) "
                    },
                    new ServiceType
                    {
                        Id = 1218670,
                        Code = "40600",
                        Name =
                            "Панель аллергенов травы: ежа сборная, овсянница луговая, рожь многолетняя, тимофеевка, мятлик луговой (GP1; Grass Panel 1: Orchard Grass, Meadow Fescue, Perennial Rye Grass, Timothy Grass, June Grass (Kentucky Blue)(кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218671,
                        Code = "40601",
                        Name =
                            "Панель аллергенов травы: колосок душистый, рожь многолетняя, тимофеевка, мятлик луговой, бухарник шерстистый (GP3; Grass Panel 3: Sweet Vernal Grass, Perennial Rye Grass, Timothy Grass, Cultivated Rye Grass, Velvet Grass) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218672,
                        Code = "40602",
                        Name =
                            "Панель аллергенов плесени: Penicillum notatum, Aspergillus fumigatus, Alternaria tenuis, Cladosporium herbarum, Candida albicans (MP1; Mold Panel 1) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218673,
                        Code = "40603",
                        Name =
                            "Панель аллергенов деревьев: ольха, лещина обыкновенная, ива, береза, дуб (TP9; Tree Panel 9: Alder, Birch, Hazelnut, Oak, Willow) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218674,
                        Code = "40604",
                        Name =
                            "Панель аллергенов сорной травы: амброзия обыкновенная, полынь обыкновенная, одуванчик лекарственный, подорожник, зольник/солянка, поташник (WP1; Common Ragweed, Mugwort, English Plantain, Lambs Quarters, Scale) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218675,
                        Code = "40605",
                        Name = "Кошка (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218676,
                        Code = "40606",
                        Name = "Собака (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218677,
                        Code = "40607",
                        Name = "Яичный белок (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218678,
                        Code = "40608",
                        Name = "Коровье молоко (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218679,
                        Code = "40609",
                        Name = "Треска (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218680,
                        Code = "40610",
                        Name = "Пшеничная мука (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218681,
                        Code = "40611",
                        Name = "Арахис (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218682,
                        Code = "40612",
                        Name = "Соевые бобы (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218683,
                        Code = "40613",
                        Name = "Фундук (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218684,
                        Code = "40614",
                        Name = "Крабы (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218685,
                        Code = "40615",
                        Name = "Креветки (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218687,
                        Code = "40617",
                        Name = "Морковь (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218688,
                        Code = "40618",
                        Name = "Яичный желток (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218689,
                        Code = "40619",
                        Name = "Сельдерей (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218690,
                        Code = "40620",
                        Name = "Таракан (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218691,
                        Code = "40621",
                        Name =
                            "Клещ Dermatophagoides pteronyssinus (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218692,
                        Code = "40666",
                        Name =
                            "Панель респираторные аллергены (домашняя пыль (клещ Derm. Pteronyssinus), домашняя пыль (клещ Derm. Farinae), ольха, береза, лещина, дуб, смесь трав, рожь (пыльца), полынь, подорожник, кошка, лошадь, собака, морская свинка, золотистый хомячок, кролик, Рen"
                    },
                    new ServiceType
                    {
                        Id = 1218693,
                        Code = "40669",
                        Name =
                            "Панель пищевые аллергены (лесной орех, арахис, грецкий орех, миндальный орех, молоко, яичный белок, яичный желток, казеин, картофель,сельдерей, морковь, томаты, треска, краб, апельсин, яблоко, пшеничная мука, ржаная мука, кунжутное семя, соевые бобы)"
                    },
                    new ServiceType
                    {
                        Id = 1218686,
                        Code = "40616",
                        Name = "Томаты (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218694,
                        Code = "40670",
                        Name =
                            "Панель педиатрическая (домашняя пыль (клещ Derm. Pteronyssinus), домашняя пыль (клещ Derm. Farinae), береза, смесь трав, кошка, собака, Alternaria alternate, молоко, ?-лактальбумин, ?-лактоглобулин, казеин, яичный белок, яичный желток, бычий сывороточный"
                    },
                    new ServiceType {Id = 1218695, Code = "40672", Name = "H2 домашняя пыль/Stier/ IgE"},
                    new ServiceType {Id = 1218697, Code = "40674", Name = "Персик IgE"},
                    new ServiceType {Id = 1218698, Code = "40675", Name = "Манго IgE"},
                    new ServiceType {Id = 1218699, Code = "40676", Name = "Банан IgE"},
                    new ServiceType {Id = 1218700, Code = "40677", Name = "Ананас IgE"},
                    new ServiceType
                    {
                        Id = 1218701,
                        Code = "40805",
                        Name = "АТ к париетальным клеткам желудка (РСА) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218702,
                        Code = "40806",
                        Name = "АТ к гладкой мускулатуре (SMA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218703,
                        Code = "40807",
                        Name = "АТ к базальной мембране клеток почек (anti-GBM)(кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218704,
                        Code = "40809",
                        Name = "АТ к базальной мембране и межклеточному веществу кожи (IC/BMZ) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218705,
                        Code = "40815",
                        Name = "АТ к сердечной мускулатуре (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218706,
                        Code = "40819",
                        Name = "АТ к микросомам печени и почки (LKM-1) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218707, Code = "40840", Name = "Церулоплазмин (Coeruloplasmin)"},
                    new ServiceType {Id = 1218708, Code = "40841", Name = "Гаптоглобин (Haptoglobin)"},
                    new ServiceType {Id = 1218709, Code = "40863", Name = "Кобальт - кровь сыворотка"},
                    new ServiceType {Id = 1218710, Code = "40868", Name = "Цинк - кровь сыворотка"},
                    new ServiceType {Id = 1218711, Code = "40869", Name = "Селен - кровь сыворотка"},
                    new ServiceType {Id = 1218712, Code = "40873", Name = "Молибден -кровь сыворотка"},
                    new ServiceType {Id = 1218713, Code = "40874", Name = "Кадмий - кровь сыворотка"},
                    new ServiceType {Id = 1218714, Code = "40878", Name = "Свинец - кровь цельная"},
                    new ServiceType {Id = 1218715, Code = "40881", Name = "Алюминий (моча)"},
                    new ServiceType {Id = 1218716, Code = "40883", Name = "Мышьяк - кровь сыворотка"},
                    new ServiceType {Id = 1218717, Code = "40888", Name = "Медь - кровь сыворотка"},
                    new ServiceType {Id = 1218718, Code = "40892", Name = "Марганец - кровь сыворотка"},
                    new ServiceType {Id = 1218719, Code = "40893", Name = "Никель - кровь сыворотка"},
                    new ServiceType {Id = 1218720, Code = "40894", Name = "Никель (моча)"},
                    new ServiceType {Id = 1218721, Code = "40895", Name = "Свинец (моча)"},
                    new ServiceType {Id = 1218722, Code = "40897", Name = "Амфетамины -Моча"},
                    new ServiceType {Id = 1218723, Code = "40898", Name = "Барбитураты -Моча"},
                    new ServiceType {Id = 1218724, Code = "40900", Name = "Бензодиазепины -Моча"},
                    new ServiceType {Id = 1218726, Code = "40916", Name = "Кокаин (метаболит) - Моча"},
                    new ServiceType {Id = 1218727, Code = "40920", Name = "Метадон -Моча"},
                    new ServiceType
                    {
                        Id = 1218729,
                        Code = "40623",
                        Name = "Penicillum notatum (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218730,
                        Code = "40624",
                        Name = "Cladosporium herbarum (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218731,
                        Code = "40625",
                        Name = "Aspergillus fumigatus (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218732,
                        Code = "40626",
                        Name = "Candida albicans (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218733,
                        Code = "40627",
                        Name = "Alternaria tenuis(кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218734,
                        Code = "40628",
                        Name = "Латекс (K82, Latex) (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType {Id = 1218735, Code = "40629", Name = "C70 инсулин свиной IgE"},
                    new ServiceType {Id = 1218736, Code = "40630", Name = "C71 инсулин бычий IgE"},
                    new ServiceType
                    {
                        Id = 1218737,
                        Code = "40631",
                        Name = "Домашняя пыль (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218738,
                        Code = "40632",
                        Name = "Пекарские дрожжи(кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218739,
                        Code = "40633",
                        Name = "Шоколад (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218740,
                        Code = "40634",
                        Name = "Клубника (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218741,
                        Code = "40635",
                        Name = "Лимон (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218742,
                        Code = "40636",
                        Name = "Грейпфрут (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218743,
                        Code = "40637",
                        Name =
                            "Панель пищевых аллергенов 1: Апельсин, банан, яблоко, персик (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218744,
                        Code = "40638",
                        Name =
                            "Панель пищевых аллергенов 2: Киви, манго, банан, ананас (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218745,
                        Code = "40639",
                        Name =
                            "Панель пищевых аллергенов 3: Свинина, куриное мясо, говядина, баранина (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1218746,
                        Code = "40640",
                        Name = "Тополь (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType {Id = 1218747, Code = "40641", Name = "F11 гречневая мука IgE"},
                    new ServiceType {Id = 1218748, Code = "40642", Name = "F216 капуста кочанной IgE"},
                    new ServiceType {Id = 1218749, Code = "40643", Name = "F225 тыква IgE"},
                    new ServiceType {Id = 1218750, Code = "40644", Name = "F26 свинина IgE"},
                    new ServiceType {Id = 1218751, Code = "40645", Name = "F27 говядина IgE"},
                    new ServiceType {Id = 1218752, Code = "40646", Name = "F35 картофель IgE"},
                    new ServiceType {Id = 1218753, Code = "40647", Name = "F55 просо IgE"},
                    new ServiceType {Id = 1218754, Code = "40648", Name = "F7 овсяная мука IgE"},
                    new ServiceType {Id = 1218755, Code = "40649", Name = "F77 бета-лактоглобин IgE"},
                    new ServiceType {Id = 1218756, Code = "40650", Name = "F78 казеин IgE"},
                    new ServiceType {Id = 1218757, Code = "40651", Name = "F83 куриное мясо IgE"},
                    new ServiceType {Id = 1218758, Code = "40652", Name = "F9 рис IgE"},
                    new ServiceType {Id = 1218759, Code = "40653", Name = "F49 яблоко IgE"},
                    new ServiceType {Id = 1218761, Code = "40655", Name = "F403 пивные дрожжи IgE"},
                    new ServiceType {Id = 1218762, Code = "40656", Name = "G6 тимофеевка IgE"},
                    new ServiceType {Id = 1218763, Code = "40657", Name = "T3 береза IgE"},
                    new ServiceType {Id = 1218764, Code = "40658", Name = "W6 полынь IgE"},
                    new ServiceType {Id = 1218765, Code = "40659", Name = "W5 полынь горькая IgE"},
                    new ServiceType {Id = 1218767, Code = "40661", Name = "E78 волнистый попугай перо IgE"},
                    new ServiceType {Id = 1218768, Code = "40662", Name = "E81 овца эпителий IgE"},
                    new ServiceType {Id = 1218769, Code = "40663", Name = "E85 курица перо IgE"},
                    new ServiceType {Id = 1218771, Code = "40010", Name = "Альбумин (Albumin)"},
                    new ServiceType {Id = 1218772, Code = "40011", Name = "Пренатальный скрининг"},
                    new ServiceType
                    {
                        Id = 1218773,
                        Code = "40012",
                        Name = "Альфа-Амилаза панкреатическая (Pancreatic Alfa-amylase, P-изофермент амилазы)"
                    },
                    new ServiceType {Id = 1218774, Code = "40014", Name = "Диагностика остеопороза"},
                    new ServiceType {Id = 1218775, Code = "40017", Name = "Фруктозамин ( Fructosamine)"},
                    new ServiceType
                    {
                        Id = 1218777,
                        Code = "40019",
                        Name = "Креатинкиназа (Креатинфосфокиназа, КК, КФК, CK, Creatine kinaze)"
                    },
                    new ServiceType
                    {
                        Id = 1218778,
                        Code = "40020",
                        Name =
                            "Креатинкиназа-МВ (Креатинфосфокиназа-МВ, КК-МВ, КФК-МВ, Creatine Kinase-MB, CK-MB, КК-2)"
                    },
                    new ServiceType {Id = 1218779, Code = "40021", Name = "Миоглобин (Myoglobin)"},
                    new ServiceType {Id = 1218780, Code = "40022", Name = "Аллергия на растения"},
                    new ServiceType
                    {
                        Id = 1218781,
                        Code = "40023",
                        Name = "Липаза (Триацилглицеролацилгидролаза, Lipase)"
                    },
                    new ServiceType
                    {
                        Id = 1218782,
                        Code = "40024",
                        Name = "ЛДГ (Лактатдегидрогеназа, L-лактат: НАД+Оксидоредуктаза, Lactate dehydrogenase, LDH)"
                    },
                    new ServiceType
                    {
                        Id = 1218783,
                        Code = "40025",
                        Name =
                            "1-ый изофермент ЛДГ (ЛДГ-1, альфа-гидроксибутират дегидрогеназа, изофермент лактатдегидрогеназы-1, Alfa-HBDH)"
                    },
                    new ServiceType {Id = 1218784, Code = "40026", Name = "Хочу стать мамой: планирование беременности"},
                    new ServiceType {Id = 1218785, Code = "40027", Name = "Хочу стать мамой: гормональный"},
                    new ServiceType {Id = 1218786, Code = "40028", Name = "Хочу стать мамой: комплексное обследование"},
                    new ServiceType
                    {
                        Id = 1218787,
                        Code = "40029",
                        Name = "Белковые фракции (Serum Protein Electrophoresis, SPE)"
                    },
                    new ServiceType
                    {
                        Id = 1218788,
                        Code = "40030",
                        Name = "В ожидании малыша: 2-й триместр (12-28 неделя беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218789,
                        Code = "40031",
                        Name = "В ожидании малыша: 3-й триместр (с 29-ой по 30-ю неделю беременности)"
                    },
                    new ServiceType {Id = 1218790, Code = "40033", Name = "Здоровый ребенок: для детей от 0 до 14 лет"},
                    new ServiceType
                    {
                        Id = 1218791,
                        Code = "40034",
                        Name =
                            "Холинэстераза (S-Псевдохолинэстераза, холинэстераза II, S-ХЭ, ацилхолин-ацилгидролаза, Cholinesterase)"
                    },
                    new ServiceType
                    {
                        Id = 1218792,
                        Code = "40035",
                        Name = "Фосфатаза кислая (КФ, Acid phosphatase, ACP)"
                    },
                    new ServiceType {Id = 1218793, Code = "40036", Name = "Секс в большом городе: анализ крови"},
                    new ServiceType
                    {
                        Id = 1218794,
                        Code = "40037",
                        Name = "Кальций общий (Ca, Calcium total) - кровь сыворотка"
                    },
                    new ServiceType {Id = 1218795, Code = "40038", Name = "Женские проблемы: гормоны"},
                    new ServiceType
                    {
                        Id = 1218796,
                        Code = "40039",
                        Name = "Калий (К+, Potassium), Натрий (Na+, Sodium), Хлор (Сl-, Chloride)- кровь"
                    },
                    new ServiceType {Id = 1218797, Code = "40040", Name = "Магний (Мg, Magnesium) - кровь сыворотка"},
                    new ServiceType
                    {
                        Id = 1218798,
                        Code = "40041",
                        Name = "Фосфор неорганический (P, Phosphorus) - кровь сыворотка"
                    },
                    new ServiceType {Id = 1218799, Code = "40042", Name = "VIP-обследование для женщин"},
                    new ServiceType {Id = 1218800, Code = "40043", Name = "VIP-обследование для мужчин"},
                    new ServiceType
                    {
                        Id = 1218801,
                        Code = "40044",
                        Name = "Ревматоидный фактор (РФ, Rheumatoid factor,RF)"
                    },
                    new ServiceType
                    {
                        Id = 1218802,
                        Code = "40045",
                        Name = "Иммуноглобулины класса A (IgA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218803,
                        Code = "40046",
                        Name = "Иммуноглобулины класса М (IgM) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218804,
                        Code = "40047",
                        Name = "Иммуноглобулины класса G (IgG) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218805, Code = "40048", Name = "Железо (Fe, Iron) - кровь"},
                    new ServiceType
                    {
                        Id = 1218806,
                        Code = "40049",
                        Name =
                            "Латентная (ненасыщенная) железосвязывающая способность сыворотки крови (ЛЖСС, НЖСС, Unsaturated Iron Binding Capacity, UIBC)"
                    },
                    new ServiceType {Id = 1218807, Code = "40050", Name = "КАРДИОРИСК: рекомендуемый"},
                    new ServiceType {Id = 1218808, Code = "40051", Name = "КАРДИОРИСК: скрининг"},
                    new ServiceType {Id = 1218809, Code = "40052", Name = "Острый коронарный синдром"},
                    new ServiceType
                    {
                        Id = 1219274,
                        Code = "47944",
                        Name = "Полное генетичесоке VIP обследование для женщин"
                    },
                    new ServiceType
                    {
                        Id = 1219275,
                        Code = "47945",
                        Name = "Полное генетическое VIP обследование для мужчин"
                    },
                    new ServiceType
                    {
                        Id = 1219276,
                        Code = "47946",
                        Name = "Полное генетическое обследование супружеской пары (женщина)*"
                    },
                    new ServiceType
                    {
                        Id = 1219277,
                        Code = "47947",
                        Name = "Полное генетическое обследование супружеской пары (мужчина)*"
                    },
                    new ServiceType {Id = 1219278, Code = "47948", Name = "Здоровая семья (Ж)"},
                    new ServiceType {Id = 1219279, Code = "47949", Name = "Здоровая семья (М)"},
                    new ServiceType
                    {
                        Id = 1219280,
                        Code = "47950",
                        Name = "Полное генетическое обследование ребенка (девочка)"
                    },
                    new ServiceType
                    {
                        Id = 1219281,
                        Code = "47951",
                        Name = "Полное генетическое обследование ребенка (мальчик)"
                    },
                    new ServiceType {Id = 1219282, Code = "47952", Name = "Здоровье ребенка (Д)"},
                    new ServiceType {Id = 1219283, Code = "47953", Name = "Здоровье ребенка (М)"},
                    new ServiceType {Id = 1219284, Code = "47954", Name = "Здоровый образ жизни"},
                    new ServiceType {Id = 1219285, Code = "47955", Name = "Я здоров (М)"},
                    new ServiceType {Id = 1219286, Code = "47956", Name = "Я здоров (Ж)"},
                    new ServiceType {Id = 1219287, Code = "47957", Name = "Мужское бесплодие (+кариотип)*"},
                    new ServiceType {Id = 1219288, Code = "47958", Name = "Хочу стать мамой:осложнения беременности"},
                    new ServiceType
                    {
                        Id = 1219289,
                        Code = "47959",
                        Name = "Женское бесплодие и осложнение беременности*"
                    },
                    new ServiceType {Id = 1219290, Code = "47960", Name = "M. tuberculosis complex (соскоб)"},
                    new ServiceType {Id = 1219291, Code = "47961", Name = "Подготовка к операции"},
                    new ServiceType {Id = 1219292, Code = "47962", Name = "Сердечно-сосудистые заболевания"},
                    new ServiceType {Id = 1219293, Code = "47963", Name = "Онкологические заболевания у мужчин"},
                    new ServiceType {Id = 1219294, Code = "47964", Name = "Онкологические заболевания у женщин"},
                    new ServiceType
                    {
                        Id = 1218992,
                        Code = "40333",
                        Name = "Аспергилла (Aspergillus fumigatus), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218993,
                        Code = "40334",
                        Name = "Хламидия (Chlamydia trachomatis), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218994,
                        Code = "40335",
                        Name = "Токсоплазма (Toxoplasma gondii), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218995,
                        Code = "40336",
                        Name = "Бледная трепонема (Treponema pallidum), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218996,
                        Code = "40337",
                        Name =
                            "Т-лимфотропный человеческий вирус I типа (Human T - lymphotropic virus I/II), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218997,
                        Code = "40338",
                        Name = "Вирус краснухи (Rubella virus), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218998,
                        Code = "40355",
                        Name = "Микобактерии туберкулеза (M.Bovis+M.Tuberculosis), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1218999,
                        Code = "40356",
                        Name = "Микоплазма (Mycoplasma pneumoniae), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219000,
                        Code = "40357",
                        Name = "Стрептококк (Streptococcus pneumoniae), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219001,
                        Code = "40358",
                        Name = "Хламидия (Chlamydia pneumoniae), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219002,
                        Code = "40359",
                        Name = "Аспергилла (Aspergillus fumigatus), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219003,
                        Code = "40360",
                        Name = "Гемофильная палочка (Haemophilus influenzae), определение ДНК (мокрота)"
                    },
                    new ServiceType
                    {
                        Id = 1219004,
                        Code = "40361",
                        Name = "Гемофильная палочка (Haemophilus influenzae), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1219306,
                        Code = "47977",
                        Name = "Опасность при приеме оральных контрацептивов"
                    },
                    new ServiceType
                    {
                        Id = 1219307,
                        Code = "47978",
                        Name = "Индивидуальный риск последствий приема оральных контрацептивов"
                    },
                    new ServiceType {Id = 1219308, Code = "47979", Name = "Глутатионтрансферазы"},
                    new ServiceType
                    {
                        Id = 1219309,
                        Code = "47980",
                        Name = "Бледная трепонема (Treponema pallidum) (соскоб)"
                    },
                    new ServiceType {Id = 1219310, Code = "47981", Name = "ЦИК"},
                    new ServiceType {Id = 1219311, Code = "47982", Name = "Обмен Фолиевой кислоты"},
                    new ServiceType
                    {
                        Id = 1219313,
                        Code = "47984",
                        Name = "Артериальная гипертензия, связанная с нарушениями в ренинангиотензиновой системе"
                    },
                    new ServiceType {Id = 1219314, Code = "47985", Name = "Гиперагрегация тромбоцитов"},
                    new ServiceType {Id = 1219315, Code = "47986", Name = "Тромбозы - минимум"},
                    new ServiceType
                    {
                        Id = 1219316,
                        Code = "47987",
                        Name =
                            "Тромбофилия (данный тест является обязательным генетическим анализом для беременных по рекомендациям ВОЗ)"
                    },
                    new ServiceType
                    {
                        Id = 1219317,
                        Code = "47988",
                        Name = "Семейные случаи рака молочной железы и/или яичников"
                    },
                    new ServiceType
                    {
                        Id = 1219318,
                        Code = "47989",
                        Name = "Семейные случаи рака молочной железы и/или яичников"
                    },
                    new ServiceType {Id = 1219319, Code = "47990", Name = "Онко ? гены для женщин ? минимум"},
                    new ServiceType {Id = 1219320, Code = "47991", Name = "Основные наследственные заболевания"},
                    new ServiceType {Id = 1219321, Code = "47992", Name = "Основные наследственные заболевания ? гены"},
                    new ServiceType {Id = 1219322, Code = "47993", Name = "Ожирение алиментарное"},
                    new ServiceType
                    {
                        Id = 1219323,
                        Code = "47994",
                        Name = "Онкологические заболевания, связанные с токсинами окружающей среды"
                    },
                    new ServiceType {Id = 1219324, Code = "47996", Name = "Артериальная гипертензия (полная панель)"},
                    new ServiceType {Id = 1219325, Code = "47997", Name = "Токсоплазма (Toxoplasma gondii)"},
                    new ServiceType
                    {
                        Id = 1219326,
                        Code = "47998",
                        Name = "Склонность к тромбозам при беременности ? минимум"
                    },
                    new ServiceType {Id = 1219327, Code = "47999", Name = "Пеницилламин"},
                    new ServiceType {Id = 1219328, Code = "48000", Name = "Риск развития рака при курении"},
                    new ServiceType {Id = 1219329, Code = "48001", Name = "Необходимость защиты кожи при загаре"},
                    new ServiceType
                    {
                        Id = 1219330,
                        Code = "48002",
                        Name = "Приём жаренных и копченых продуктов и риск развития рака"
                    },
                    new ServiceType
                    {
                        Id = 1219331,
                        Code = "48003",
                        Name = "Возникновение изолированных пороков развития у плода"
                    },
                    new ServiceType {Id = 1219332, Code = "48004", Name = "Гипергомоцистеинемия"},
                    new ServiceType {Id = 1219333, Code = "48005", Name = "Гестозы и фетоплацентарная недостаточность"},
                    new ServiceType
                    {
                        Id = 1219334,
                        Code = "48006",
                        Name =
                            "Вирусы папилломы человека 16 и 18 типов (Human papillomavirus, HPV-16,18; высокий риск) (соскоб)"
                    },
                    new ServiceType {Id = 1219335, Code = "48007", Name = "Привычное невынашивание беременности*"},
                    new ServiceType
                    {
                        Id = 1219336,
                        Code = "48008",
                        Name = "Тромботические осложнения при стимуляции овуляции"
                    },
                    new ServiceType
                    {
                        Id = 1219337,
                        Code = "48009",
                        Name = "Ингибиторы АПФ, флувастатин, блокаторы рецепторов АТII"
                    },
                    new ServiceType {Id = 1219338, Code = "48010", Name = "Ишемический инсульт"},
                    new ServiceType {Id = 1219339, Code = "48011", Name = "ИБС, инфаркт миокарда"},
                    new ServiceType
                    {
                        Id = 1219340,
                        Code = "48012",
                        Name = "Оценка рисков, связанных с интенсивной физической нагрузкой"
                    },
                    new ServiceType {Id = 1219341, Code = "48013", Name = "Генетические факторы мужского бесплодия"},
                    new ServiceType {Id = 1219342, Code = "48014", Name = "Метотрексат"},
                    new ServiceType
                    {
                        Id = 1219343,
                        Code = "48015",
                        Name =
                            "Вирусы папилломы человека 31 и 33 типов (Human papillomavirus, HPV-31,33; высокий риск) (соскоб)"
                    },
                    new ServiceType
                    {
                        Id = 1219344,
                        Code = "48016",
                        Name = "Герпесвирус I и II типа (Herpes Simplex virus I, II) соскоб"
                    },
                    new ServiceType
                    {
                        Id = 1219345,
                        Code = "48017",
                        Name =
                            "Вирус папилломы человека ВКР-генотип: (16,31,33,35,18,45,39,59,52,56,58,66 типы) (соскоб)"
                    },
                    new ServiceType
                    {
                        Id = 1219346,
                        Code = "48018",
                        Name =
                            "Anti-Mycoplasma hominis-IgM/G (антитела класса IgM и класса IgG к Mycoplasma hominis) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219347, Code = "48019", Name = "U. Urealyticum и U.parvum (соскоб)"},
                    new ServiceType
                    {
                        Id = 1219348,
                        Code = "48020",
                        Name =
                            "Anti-Mycoplasma pneumonia-IgM/G (антитела класса IgM и класса IgG к Mycoplasma pneumonia) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1219349,
                        Code = "48021",
                        Name =
                            "Вирус папилломы человека ВКР ? скрининг (16,18,31,33,35,39,45,52,53,56,58,59,67) (соскоб)"
                    },
                    new ServiceType
                    {
                        Id = 1219350,
                        Code = "48022",
                        Name =
                            "Пренатальный скрининг трисомий: 1 триместр (PRISKA-1) (кровь (сыворотка) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1219351,
                        Code = "48023",
                        Name = "Хламидии (Chlamydia trachomatis), определение ДНК * соскоб"
                    },
                    new ServiceType
                    {
                        Id = 1219352,
                        Code = "48024",
                        Name =
                            "Вирусы папилломы человека 6, 11 типов (Human papillomavirus, HPV-6,11 низкий риск) (соскоб)"
                    },
                    new ServiceType
                    {
                        Id = 1219353,
                        Code = "48025",
                        Name = "Исследование клеща на клещевой энцефалит методом ИФА (клещ)"
                    },
                    new ServiceType
                    {
                        Id = 1219354,
                        Code = "48026",
                        Name = "Исследование клеща на Лайм-Боррелиоз методом ПЦР (клещ)"
                    },
                    new ServiceType
                    {
                        Id = 1219355,
                        Code = "48027",
                        Name =
                            "Вирусы папилломы человека, определение клинически значимого количества ВПЧ ВКР-скрининг (16, 18, 31, 33, 35, 39, 45, 52, 58, 59, 67) (соскоб)"
                    },
                    new ServiceType
                    {
                        Id = 1219356,
                        Code = "48028",
                        Name = "Вирус Эпштейн-Барр, определение ДНК (соскоб, ликвор, слюна (околоушной железы))"
                    },
                    new ServiceType
                    {
                        Id = 1219357,
                        Code = "48029",
                        Name =
                            "Пренатальный скрининг трисомий: 2 триместр (PRISKA-2) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType {Id = 1219358, Code = "48030", Name = "Ureaplasma spp. (соскоб)"},
                    new ServiceType {Id = 1219359, Code = "48031", Name = "Ат к митохондриям (кровь (сыворотка))"},
                    new ServiceType {Id = 1219360, Code = "48032", Name = "Антиовариальные Ат (кровь (сыворотка))"},
                    new ServiceType
                    {
                        Id = 1219362,
                        Code = "48034",
                        Name =
                            "Исследование на наличие персистирующей хламидийной инфекции (АТ к белку теплового шока хламидий) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219363, Code = "48035", Name = "IgM к лямблиям кровь (сыворотка)"},
                    new ServiceType
                    {
                        Id = 1219364,
                        Code = "48036",
                        Name =
                            "Иммунограмма тесты 1 уровня (кровь (сыворотка) + цельная кровь ? ЭДТА + цельная кровь- Li-гепарин)"
                    },
                    new ServiceType
                    {
                        Id = 1219365,
                        Code = "48037",
                        Name =
                            "Иммунограмма тесты 3 уровням методом проточной цитометрии (основные субпопуляции) (цельная кровь ? ЭДТА )"
                    },
                    new ServiceType {Id = 1219107, Code = "41117", Name = "Селен - цельная кровь"},
                    new ServiceType {Id = 1219108, Code = "41118", Name = "Таллий - кровь сыворотка"},
                    new ServiceType {Id = 1219109, Code = "41119", Name = "Цинк - цельная кровь"},
                    new ServiceType {Id = 1219110, Code = "41120", Name = "Ванадий (ногти)"},
                    new ServiceType {Id = 1219111, Code = "41121", Name = "Вольфрам (ногти)"},
                    new ServiceType {Id = 1219112, Code = "41122", Name = "Цинк (ногти)"},
                    new ServiceType {Id = 1219113, Code = "41123", Name = "Цирконий (ногти)"},
                    new ServiceType {Id = 1219114, Code = "41124", Name = "Серебро (волосы)"},
                    new ServiceType {Id = 1219115, Code = "41125", Name = "Золото (волосы)"},
                    new ServiceType {Id = 1219116, Code = "41126", Name = "Барий (волосы)"},
                    new ServiceType {Id = 1219117, Code = "41127", Name = "Бериллий (волосы)"},
                    new ServiceType {Id = 1219118, Code = "41128", Name = "Висмут (волосы)"},
                    new ServiceType {Id = 1219119, Code = "41129", Name = "Галлий (волосы)"},
                    new ServiceType {Id = 1219120, Code = "41130", Name = "Германий (волосы)"},
                    new ServiceType {Id = 1219121, Code = "41131", Name = "Йод (волосы)"},
                    new ServiceType {Id = 1219122, Code = "41132", Name = "Лантан (волосы)"},
                    new ServiceType {Id = 1219123, Code = "41133", Name = "Фосфор (волосы)"},
                    new ServiceType {Id = 1219124, Code = "41134", Name = "Платина (волосы)"},
                    new ServiceType {Id = 1219125, Code = "41135", Name = "Рубидий (волосы)"},
                    new ServiceType {Id = 1219126, Code = "41136", Name = "Олово (волосы)"},
                    new ServiceType {Id = 1219127, Code = "41137", Name = "Стронций (волосы)"},
                    new ServiceType {Id = 1219128, Code = "41138", Name = "Ванадий (волосы)"},
                    new ServiceType {Id = 1219129, Code = "41139", Name = "Вольфрам (волосы)"},
                    new ServiceType
                    {
                        Id = 1219132,
                        Code = "41142",
                        Name = "Иммуноблот рекомбинантный, антитела к вирусу краснухи, IgG (recomBlot Rubella IgG)"
                    },
                    new ServiceType
                    {
                        Id = 1219133,
                        Code = "41143",
                        Name =
                            "Иммуноблот рекомбинантный, антитела к вирусу гепатита С, IgG (recomBlot HCV IgG) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1219134,
                        Code = "41144",
                        Name =
                            "Анти-Мюллеров гормон (АМГ, AMH, anti-Mullerian hormone, MIS, Mullerian Inhibiting Substance) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1219135,
                        Code = "41145",
                        Name =
                            "Ингибин В (inhibin B) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType {Id = 1219136, Code = "41200", Name = "Альфа-1-антитрипсин"},
                    new ServiceType
                    {
                        Id = 1219137,
                        Code = "41202",
                        Name = "МЯС Тест на видоспецифичность мясных продуктов"
                    },
                    new ServiceType
                    {
                        Id = 1219138,
                        Code = "41203",
                        Name = "ГМО Определение (качественное)ГМО,сои и кукурузы в сырье и продуктах питания"
                    },
                    new ServiceType
                    {
                        Id = 1219140,
                        Code = "41208",
                        Name = "Антитела (IgG) к Т- лимфотропному вирусу человека I и II"
                    },
                    new ServiceType {Id = 1219141, Code = "41211", Name = "Ванилилминдальная кислота"},
                    new ServiceType {Id = 1219142, Code = "41515", Name = "Клинический анализ крови"},
                    new ServiceType {Id = 1219143, Code = "46601", Name = "F77 бета-лактоглобин IgG"},
                    new ServiceType {Id = 1219144, Code = "46602", Name = "F78 казеин IgG"},
                    new ServiceType {Id = 1219145, Code = "46603", Name = "F83 куриное мясо IgG"},
                    new ServiceType {Id = 1219146, Code = "46604", Name = "F85 сельдерей IgG"},
                    new ServiceType {Id = 1219147, Code = "46605", Name = "F9 рис IgG"},
                    new ServiceType {Id = 1219148, Code = "46606", Name = "F49 яблоко IgG"},
                    new ServiceType {Id = 1219149, Code = "46607", Name = "F25 томат IgG"},
                    new ServiceType {Id = 1219150, Code = "46608", Name = "F84 киви IgG"},
                    new ServiceType {Id = 1219151, Code = "46609", Name = "F208 лимон IgG"},
                    new ServiceType {Id = 1219152, Code = "46610", Name = "F403 пивные дрожжи IgG"},
                    new ServiceType {Id = 1219154, Code = "46612", Name = "FP15 (апельсин, яблоко, банан, персик) IgG"},
                    new ServiceType
                    {
                        Id = 1219155,
                        Code = "46613",
                        Name = "FP73 (свинина, говядина, курица, баранина) IgG"
                    },
                    new ServiceType {Id = 1219156, Code = "46614", Name = "M1 Penicillinum notatum IgG"},
                    new ServiceType {Id = 1219157, Code = "46615", Name = "M2 Cladosporium herbarum IgG"},
                    new ServiceType {Id = 1219158, Code = "46616", Name = "M3 Aspergillus fumigatus IgG"},
                    new ServiceType {Id = 1219159, Code = "46617", Name = "M5 Candida albicans IgG"},
                    new ServiceType {Id = 1219160, Code = "46618", Name = "M6 Alternaria tenuisv IgG"},
                    new ServiceType
                    {
                        Id = 1219161,
                        Code = "46619",
                        Name =
                            "MP1 (Penicill. notatum, Clad. herbarum, Asp. fumigafus, Cand. albicans, Alter. Senuis) IgG"
                    },
                    new ServiceType {Id = 1219162, Code = "46620", Name = "T3 береза IgG"},
                    new ServiceType {Id = 1219163, Code = "46621", Name = "T14 тополь IgG"},
                    new ServiceType {Id = 1219164, Code = "46622", Name = "W6 полынь IgG"},
                    new ServiceType {Id = 1219165, Code = "46623", Name = "W5 полынь горькая IgG"},
                    new ServiceType {Id = 1219166, Code = "46624", Name = "G6 тимофеевка IgG"},
                    new ServiceType
                    {
                        Id = 1219167,
                        Code = "46625",
                        Name = "GP1 (ежа сборная, овсяница луговая, рожь многолетняя, тимофеевка, мятлик луговой) IgG"
                    },
                    new ServiceType
                    {
                        Id = 1219168,
                        Code = "46626",
                        Name =
                            "GP3 (колосок душист. рожь многолет. тимофеевка. рожь культивир. бухарник шерстистый) IgG"
                    },
                    new ServiceType
                    {
                        Id = 1219169,
                        Code = "46627",
                        Name = "WP1(амброзия обык. зольник-солянка. одуванчик лекарств. подорожник. полынь обыкн.) IgG"
                    },
                    new ServiceType
                    {
                        Id = 1219170,
                        Code = "46628",
                        Name = "TP9 (ольха. ива. лещина обыкнов. дуб. береза.) IgG"
                    },
                    new ServiceType {Id = 1219171, Code = "46629", Name = "K82 латекс IgG"},
                    new ServiceType {Id = 1219172, Code = "46630", Name = "C70 инсулин бычий IgG"},
                    new ServiceType {Id = 1219173, Code = "46631", Name = "C71 инсулин свиной IgG"},
                    new ServiceType {Id = 1219174, Code = "46632", Name = "D1 Dermatophagoides pteronyssinus IgG"},
                    new ServiceType {Id = 1219175, Code = "46633", Name = "D2 Dermatophagoides farinae IgG"},
                    new ServiceType {Id = 1219177, Code = "46635", Name = "H1 домашняя пыль/Greer/ IgG"},
                    new ServiceType {Id = 1219178, Code = "46636", Name = "H2 домашняя пыль/Stier/ IgG"},
                    new ServiceType {Id = 1219179, Code = "46637", Name = "I6 таракана-прусака IgG"},
                    new ServiceType {Id = 1219180, Code = "46638", Name = "E1 кошка эпителий IgG"},
                    new ServiceType {Id = 1219181, Code = "46639", Name = "E2 собака эпителий IgG"},
                    new ServiceType {Id = 1219183, Code = "46641", Name = "E81 овца эпителий IgG"},
                    new ServiceType {Id = 1219184, Code = "46642", Name = "E85 курица перо IgG"},
                    new ServiceType {Id = 1219185, Code = "46643", Name = "F1 яичный белок IgG"},
                    new ServiceType {Id = 1219186, Code = "46644", Name = "F11 гречневая мука IgG"},
                    new ServiceType {Id = 1219188, Code = "46646", Name = "F14 соевые бобы IgG"},
                    new ServiceType {Id = 1219189, Code = "46647", Name = "F17 фундук IgG"},
                    new ServiceType {Id = 1219190, Code = "46648", Name = "F2 коровье молоко IgG"},
                    new ServiceType {Id = 1219192, Code = "46650", Name = "F225 тыква IgG"},
                    new ServiceType {Id = 1219193, Code = "46651", Name = "F23 крабы IgG"},
                    new ServiceType {Id = 1219195, Code = "46653", Name = "F26 свинина IgG"},
                    new ServiceType {Id = 1219198, Code = "46656", Name = "F31 морковь IgG"},
                    new ServiceType {Id = 1219199, Code = "46657", Name = "F35 картофель IgG"},
                    new ServiceType {Id = 1219201, Code = "46659", Name = "F44 клубника IgG"},
                    new ServiceType {Id = 1219202, Code = "46660", Name = "F55 просо IgG"},
                    new ServiceType {Id = 1219203, Code = "46661", Name = "F7 овсяная мука IgG"},
                    new ServiceType {Id = 1219205, Code = "46663", Name = "E78 волнистый попугай перо IgG"},
                    new ServiceType {Id = 1219206, Code = "46664", Name = "Пекарские дрожжи IgG"},
                    new ServiceType {Id = 1219207, Code = "46665", Name = "Шоколад IgG"},
                    new ServiceType {Id = 1219210, Code = "46668", Name = "Баранина IgG"},
                    new ServiceType {Id = 1219211, Code = "46669", Name = "Персик IgG"},
                    new ServiceType {Id = 1219212, Code = "46670", Name = "Манго IgG"},
                    new ServiceType {Id = 1219214, Code = "46672", Name = "Ананас IgG"},
                    new ServiceType {Id = 1219215, Code = "46771", Name = "Спинальная амиотрофия (типы I, II, III)"},
                    new ServiceType {Id = 1219216, Code = "47201", Name = "Тромбоцитарный рецептор фибриногена"},
                    new ServiceType
                    {
                        Id = 1219217,
                        Code = "47261",
                        Name =
                            "Анализ полиморфизмов в гене цитохрома Р450, семейства 2, подсемейства C, полипептид 9 (CYP2C9) (1 чел.)"
                    },
                    new ServiceType {Id = 1219218, Code = "47601", Name = "N-ацетилтрансфераза 2"},
                    new ServiceType
                    {
                        Id = 1219219,
                        Code = "47611",
                        Name = "Артериальная гипертензия, связанная с нарушениями в работе эндотелиальной NO-синтазы"
                    },
                    new ServiceType
                    {
                        Id = 1219220,
                        Code = "47641",
                        Name = "Анализ полиморфизмов гена аполипопротеина Е (ApoE) (1 чел.)"
                    },
                    new ServiceType {Id = 1219221, Code = "47661", Name = "Нарушение сперматогенеза"},
                    new ServiceType
                    {
                        Id = 1219222,
                        Code = "47691",
                        Name = "Анализ полиморфизмов в гене лактазы (LCT) (1 чел.)"
                    },
                    new ServiceType {Id = 1219223, Code = "47781", Name = "Фенилкетонурия"},
                    new ServiceType {Id = 1219224, Code = "47791", Name = "Муковисцидоз"},
                    new ServiceType {Id = 1219225, Code = "47801", Name = "Несиндромальная нейросенсорная тугоухость"},
                    new ServiceType {Id = 1219226, Code = "47802", Name = "Адреногенитальный синдром"},
                    new ServiceType {Id = 1219227, Code = "47811", Name = "Исследование кариотипа"},
                    new ServiceType {Id = 1219228, Code = "47821", Name = "Определение резус-фактора (1 чел.)"},
                    new ServiceType {Id = 1219208, Code = "46666", Name = "Грейпфрут IgG"},
                    new ServiceType {Id = 1219209, Code = "46667", Name = "F33 Апельсин IgG"},
                    new ServiceType
                    {
                        Id = 1219229,
                        Code = "47831",
                        Name = "Типирование по трем генам HLA II класса DQA1, DQB1, DRB (1 чел.)"
                    },
                    new ServiceType {Id = 1219231, Code = "47900", Name = "Алюминий (волосы,моча,ногти)"},
                    new ServiceType {Id = 1219232, Code = "47901", Name = "Барий( волосы,ногти)"},
                    new ServiceType {Id = 1219233, Code = "47902", Name = "Бериллий (волосы,ногти)"},
                    new ServiceType {Id = 1219234, Code = "47903", Name = "Бор (волосы,ногти)"},
                    new ServiceType {Id = 1219235, Code = "47904", Name = "Ванадий (волосы,ногти)"},
                    new ServiceType {Id = 1219237, Code = "47906", Name = "Вольфрам ( волосы,ногти)"},
                    new ServiceType {Id = 1219238, Code = "47907", Name = "Галлий (волосы,ногти)"},
                    new ServiceType {Id = 1219239, Code = "47908", Name = "Германий (волосы,ногти)"},
                    new ServiceType {Id = 1219240, Code = "47909", Name = "Железо (волосы,моча,ногти)"},
                    new ServiceType {Id = 1219241, Code = "47910", Name = "Золото (волосы,ногти, кровь (сыворотка))"},
                    new ServiceType {Id = 1219242, Code = "47911", Name = "Йод (волосы,ногти)"},
                    new ServiceType {Id = 1219244, Code = "47913", Name = "Калий (волосы, ногти)"},
                    new ServiceType {Id = 1219245, Code = "47914", Name = "Кальций (суточная моча,волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219246,
                        Code = "47915",
                        Name = "Кобальт (волосы,моча,ногти,кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219247, Code = "47916", Name = "Кремний (волосы, ногти)"},
                    new ServiceType {Id = 1219248, Code = "47917", Name = "Лантан(волосы,ногти)"},
                    new ServiceType {Id = 1219249, Code = "47918", Name = "Литий (волосы,ногти)"},
                    new ServiceType {Id = 1219250, Code = "47919", Name = "Магний (волосы,ногти, )"},
                    new ServiceType
                    {
                        Id = 1219251,
                        Code = "47920",
                        Name = "Марганец ( волосы,моча,ногти,кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType
                    {
                        Id = 1219252,
                        Code = "47921",
                        Name = "Медь ( волосы, моча, ногти, кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219253, Code = "47922", Name = "Молибден (волосы,ногти,кровь (сыворотка))"},
                    new ServiceType
                    {
                        Id = 1219254,
                        Code = "47923",
                        Name = "Мышьяк (волосы,моча,ногти, кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219255, Code = "47924", Name = "Натрий (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219256,
                        Code = "47925",
                        Name = "Никель (волосы,моча,ногти,кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219257, Code = "47926", Name = "Олова (волосы,ногти)"},
                    new ServiceType {Id = 1219258, Code = "47927", Name = "Платина (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219259,
                        Code = "47928",
                        Name = "Ртуть (волосы,моча,ногти,цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219260, Code = "47929", Name = "Рубидий (Волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219261,
                        Code = "47930",
                        Name = "Свинец (Ш волосы,моча,ногти,цельная кровь (ЭДТА))"
                    },
                    new ServiceType
                    {
                        Id = 1219262,
                        Code = "47931",
                        Name = "Селен (волосы,ногти,моча,кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219263, Code = "47932", Name = "Серебро(волосы,ногти)"},
                    new ServiceType {Id = 1219264, Code = "47933", Name = "Стронций (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219266,
                        Code = "47935",
                        Name = "Таллий (волосы,моча,ногти, кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219267, Code = "47936", Name = "Фосфор ( волосы,ногти)"},
                    new ServiceType {Id = 1219268, Code = "47937", Name = "Хром (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219269,
                        Code = "47938",
                        Name = "Цинк (волосы,моча,ногти,кровь (сыворотка), цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219270, Code = "47939", Name = "Цирконий (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219271,
                        Code = "47941",
                        Name = "Антитела к фосфолипидам IgM/IgG (anti-Phospholipid antibodies) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219272, Code = "47942", Name = "Полное генетическое обследование для женщин"},
                    new ServiceType {Id = 1219273, Code = "47943", Name = "Полное генетическое обследование для мужчин"},
                    new ServiceType {Id = 1219176, Code = "46634", Name = "D3 Dermatophagoides microceras IgG"},
                    new ServiceType {Id = 1219182, Code = "46640", Name = "E6 морская свинка эпителий IgG"},
                    new ServiceType {Id = 1219187, Code = "46645", Name = "F13 арахис IgG"},
                    new ServiceType {Id = 1219191, Code = "46649", Name = "F216 капуста кочанной IgG"},
                    new ServiceType {Id = 1219196, Code = "46654", Name = "F27 говядина IgG"},
                    new ServiceType {Id = 1219200, Code = "46658", Name = "F4 пшеничная мука IgG"},
                    new ServiceType {Id = 1219236, Code = "47905", Name = "Висмут (волосы,ногти)"},
                    new ServiceType
                    {
                        Id = 1219243,
                        Code = "47912",
                        Name = "Кадмий (волосы,моча,ногти, кровь (сыворотка),цельная кровь (ЭДТА))"
                    },
                    new ServiceType {Id = 1219405, Code = "48078", Name = "Гонококк (Neisseria gonorrhoeae) соскоб"},
                    new ServiceType {Id = 1219475, Code = "50077", Name = "Госпитализация в ТЕРАПЕВТИЧЕСКИЙ стационар"},
                    new ServiceType
                    {
                        Id = 1219481,
                        Code = "50083",
                        Name = "ХОЧУ СТАТЬ МАМОЙ: комплексное обследование при планировании беременности"
                    },
                    new ServiceType {Id = 1123003, Code = "23003", Name = "Коронка пластмассовая"},
                    new ServiceType {Id = 1121026, Code = "21026", Name = "Депофорез одного канала"},
                    new ServiceType
                    {
                        Id = 1219014,
                        Code = "40371",
                        Name =
                            "Вирус птичьего гриппа, определение РНК (качественный) (Influenza virus H5N1), (смыв с носоглотки)"
                    },
                    new ServiceType {Id = 1219050, Code = "41020", Name = "Сурьма (волосы)"},
                    new ServiceType {Id = 1219057, Code = "41036", Name = "Цинк (моча)"},
                    new ServiceType {Id = 1219095, Code = "41105", Name = "Сурьма (ногти)"},
                    new ServiceType {Id = 1219102, Code = "41112", Name = "Кадмий - цельная кровь"},
                    new ServiceType
                    {
                        Id = 1219299,
                        Code = "47969",
                        Name =
                            "Вода: оценка качества по 30 параметрам. Рекомендуется для скважин, колонок, воды бутилированной. Объем воды для анализа - 1 литр; бутыль входит в комплект пробоотбора."
                    },
                    new ServiceType
                    {
                        Id = 1219300,
                        Code = "47970",
                        Name =
                            "Вода: оценка качества по 20 параметрам. Рекомендуется для воды водопроводной, колодцев и родниковых источников. Объем воды для анализа - 1 литр; бутыль входит в комплект пробоотбора."
                    },
                    new ServiceType
                    {
                        Id = 1219301,
                        Code = "47971",
                        Name =
                            "Радиологические исследования проб питьевой воды - базовый тест на общую ?- и ?- - активность. Особенно рекомендуется для анализа воды из скважины. Объем воды для анализа - 1 литр; бутыль входит в комплект пробоотбора."
                    },
                    new ServiceType
                    {
                        Id = 1219302,
                        Code = "47972",
                        Name =
                            "Определение концентраций для 2-ух радионуклидов если в тесте № 1162СЭКВ общая ?-активность более 0,1 Бк/л, но менее 0,2 Бк/л, а ?-активности менее 1 Бк/л Объем воды для анализа ? 1 литр; бутыль входит в комплект пробоотбора."
                    },
                    new ServiceType {Id = 1219295, Code = "47965", Name = "Онкологические заболевания у женщин"},
                    new ServiceType {Id = 1219296, Code = "47966", Name = "Тромбозы (расширеная панель)"},
                    new ServiceType {Id = 1219297, Code = "47967", Name = "Остеопороз"},
                    new ServiceType {Id = 1219298, Code = "47968", Name = "Сахарный Диабет I типа"},
                    new ServiceType
                    {
                        Id = 1219303,
                        Code = "47973",
                        Name =
                            "Определение концентраций для 4-х радионуклидов если в тесте № 1162СЭКВ общая ?- активности более 0,2 Бк/л, но менее 0,4 Бк/л, а ?- активность менее 1 Бк/л. Объем воды для анализа. - 5 литров; бутыль не входит в комплект пробоотбора."
                    },
                    new ServiceType
                    {
                        Id = 1219304,
                        Code = "47974",
                        Name =
                            "Определение концентраций для 6-и радионуклидов если в тесте № 1162СЭКВ общая ?- активности более 0,4 Бк/л, а ?- активность менее 1 Бк/л. Объем воды для анализа. - 5 литров; бутыль не входит в комплект пробоотбора."
                    },
                    new ServiceType {Id = 1219305, Code = "47975", Name = "Болезнь Крона"},
                    new ServiceType
                    {
                        Id = 1218835,
                        Code = "40078",
                        Name = "Anti-HBs (антитела к HBs-антигену вируса гепатита B) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218836,
                        Code = "40079",
                        Name = "Anti-HCV-total (антитела к антигенам вируса гепатита C ) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218837,
                        Code = "40080",
                        Name = "Anti-Toxo-IgG (антитела класса IgG к Тoxoplasma gondii) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218838,
                        Code = "40081",
                        Name = "Anti-Toxo-IgM (Антитела класса IgM к Тoxoplasma gondii)"
                    },
                    new ServiceType
                    {
                        Id = 1218839,
                        Code = "40082",
                        Name = "Anti-CMV-IgG (Антитела класса IgG к цитомегаловирусу, ЦМВ, CMV)"
                    },
                    new ServiceType
                    {
                        Id = 1218840,
                        Code = "40083",
                        Name = "Anti-CMV-IgM (Антитела класса IgM к цитомегаловирусу, ЦМВ, CMV)"
                    },
                    new ServiceType
                    {
                        Id = 1218841,
                        Code = "40084",
                        Name = "Anti-Rubella-IgG (Антитела класса IgG к вирусу краснухи) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218842,
                        Code = "40085",
                        Name = "Anti-Rubella-IgM (Антитела класса IgM к вирусу краснухи) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218843,
                        Code = "40086",
                        Name =
                            "Опухолевая М2-пируваткиназа, плазма-ЭДТА (Опухолевая М2-ПК, Tumor M2-PK, EDTA-plasma) - цельная кровь"
                    },
                    new ServiceType
                    {
                        Id = 1218844,
                        Code = "40087",
                        Name = "В ОЖИДАНИИ МАЛЫША: 3-й триместр (с 29-ой по 30-ю неделю беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218845,
                        Code = "40088",
                        Name = "Фенобарбитал (Люминал, Phenobarbitalum) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218846,
                        Code = "40089",
                        Name = "Фенитоин (Дифенин, Дилантин, Phenytoin)кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218847,
                        Code = "40090",
                        Name = "Вальпроевая кислота (Acidum valproicum)кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218848,
                        Code = "40091",
                        Name =
                            "Карбамазепин кровь (Финлепсин, Тегретол, Сarbamazepine) (Amiodarone (Cordarex)) (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218849,
                        Code = "40092",
                        Name = "Альфа-фетопротеин (АФП, alfa-Fetoprotein) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218850, Code = "40093", Name = "Группа крови (Blood group, АВ0)"},
                    new ServiceType {Id = 1218851, Code = "40094", Name = "Резус-принадлежность (Rh-factor, Rh)"},
                    new ServiceType {Id = 1218852, Code = "40095", Name = "VIP-обследование для женщин"},
                    new ServiceType {Id = 1218853, Code = "40096", Name = "VIP-обследование для мужчин"},
                    new ServiceType
                    {
                        Id = 1218854,
                        Code = "40097",
                        Name = "Диагностика заболеваний верхних дыхательных путей"
                    },
                    new ServiceType {Id = 1218855, Code = "40098", Name = "Бытовые аллергены"},
                    new ServiceType
                    {
                        Id = 1218856,
                        Code = "40099",
                        Name =
                            "Соматотропный гормон (соматотропин, СТГ, Growth hormone, GH) (кровь (сыворотка)) (Соматотропная функция гипофиза)"
                    },
                    new ServiceType
                    {
                        Id = 1218857,
                        Code = "40100",
                        Name =
                            "АКТГ (Адренокортикотропный гормон, кортикотропин, Adrenocorticotropic Hormone, ACTH) (плазма - ЭДТА) - Гипофизарно-надпочечниковая система"
                    },
                    new ServiceType
                    {
                        Id = 1218858,
                        Code = "40101",
                        Name =
                            "Дегидроэпиандростерон-сульфат (ДЭА-S04, ДЭА-С, Dehydroepiandrosterone sulfate, DHEA-S) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218859,
                        Code = "40102",
                        Name =
                            "Паратиреоидный гормон (Паратгормон, Паратирин, ПТГ, Parathyroid hormone, PTH)кровь (сыворотка) Функция паращитовидных желез"
                    },
                    new ServiceType {Id = 1218860, Code = "40113", Name = "Кальций (Calcium) - суточная моча"},
                    new ServiceType
                    {
                        Id = 1218861,
                        Code = "40114",
                        Name = "Калий, Натрий (Potasium, Sodium) (суточная моча)"
                    },
                    new ServiceType {Id = 1218862, Code = "40115", Name = "Фосфор (Phosphorus) - суточная моча"},
                    new ServiceType
                    {
                        Id = 1218863,
                        Code = "40117",
                        Name = "Витамин В12 (цианокобаламин, кобаламин, Cobalamin) ()"
                    },
                    new ServiceType {Id = 1218864, Code = "40118", Name = "Фолиевая кислота (Folic Acid) ()"},
                    new ServiceType
                    {
                        Id = 1218865,
                        Code = "40122",
                        Name =
                            "Anti-HSV-IgG (антитела класса IgG к вирусу простого герпеса I и II типов, HSV-1, 2)(кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218866,
                        Code = "40123",
                        Name =
                            "Anti-HSV-IgМ (антитела класса IgМ к вирусу простого герпеса I и II типов, HSV-1, 2) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218867,
                        Code = "40125",
                        Name =
                            "Антиядерные антитела (АЯА, антинуклеарные антитела, antinuclear antibody, ANA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218868,
                        Code = "40126",
                        Name =
                            "Антитела класса IgG к двуспиральной (нативной) ДНК (анти-дсДНК IgG, anti-double-stranded (native) DNA IgG antibodies, anti-dsDNA IgG) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218869,
                        Code = "40134",
                        Name =
                            "Свободный эстриол (Е3, Estriol free) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218870,
                        Code = "40140",
                        Name = "Аллоиммунные антитела(включая антитела к Rh-антигену)"
                    },
                    new ServiceType
                    {
                        Id = 1218871,
                        Code = "40144",
                        Name = "Са 19-9 (Углеводный антиген 19-9, СА 19-9) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218872, Code = "40146", Name = "N-Остеокальцин (N-ОК, N-Оsteocalcin)"},
                    new ServiceType
                    {
                        Id = 1218873,
                        Code = "40147",
                        Name = "Дезоксипиридинолин (ДПИД) (утренняя порция мочи)"
                    },
                    new ServiceType
                    {
                        Id = 1218874,
                        Code = "40148",
                        Name =
                            "С-Пептид (C-Peptide) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218875,
                        Code = "40149",
                        Name =
                            "Глобулин, связывающий половые гормоны (ГСПГ, Sex hormone-binding globulin, SHBG) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218876,
                        Code = "40151",
                        Name = "Катехоламины (адреналин, норадреналин, дофамин) в моче (Симпато-адреналовая система)"
                    },
                    new ServiceType
                    {
                        Id = 1218877,
                        Code = "40152",
                        Name =
                            "Катехоламины (адреналин, норадреналин, дофамин) в моче (период сбора меньше 24 часов) (Симпато-адреналовая система)"
                    },
                    new ServiceType {Id = 1218878, Code = "40153", Name = "Гомоцистеин (Homocysteine)"},
                    new ServiceType
                    {
                        Id = 1218880,
                        Code = "40156",
                        Name =
                            "17-КС в моче (17-кетостероиды) (суточная моча) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType {Id = 1218881, Code = "40157", Name = "Тропонин-I (Troponin-I)"},
                    new ServiceType
                    {
                        Id = 1218882,
                        Code = "40161",
                        Name =
                            "PAPP-A (Ассоциированный с беременностью протеин-А плазмы, Pregnancy-associated Plasma Protein-A, ПАПП-А) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218883,
                        Code = "40162",
                        Name = "Эластаза 1, панкреатическая эластаза 1(Elastase 1, E1, Э1)"
                    },
                    new ServiceType
                    {
                        Id = 1219366,
                        Code = "48038",
                        Name =
                            "Иммунограмма тесты 3 уровня методом проточной цитометрии (базовая) (кровь (сыворотка) + цельная кровь ? ЭДТА + цельная кровь- Li-гепарин)"
                    },
                    new ServiceType
                    {
                        Id = 1219367,
                        Code = "48039",
                        Name = "Иммунограмма тесты 3 уровня методом проточной цитометрии (расширенная)"
                    },
                    new ServiceType
                    {
                        Id = 1219368,
                        Code = "48040",
                        Name = "Иммунофенотипирование клеток костного мозга для диагностики ЛПЗ (пробирка с ЭДТА)"
                    },
                    new ServiceType
                    {
                        Id = 1219369,
                        Code = "48041",
                        Name =
                            "Иммунофенотипирование клеток крови и костного мозга при острых гематологических заболеваниях (пробирка с ЭДТА)"
                    },
                    new ServiceType
                    {
                        Id = 1219370,
                        Code = "48042",
                        Name =
                            "Определение различных популяций лимфоцитов, основные+определение маркеров активации (CD-типирование методом проточной цитометрии) (пробирка с ЭДТА)"
                    },
                    new ServiceType {Id = 1219361, Code = "48033", Name = "СА-242(кровь (сыворотка))"},
                    new ServiceType
                    {
                        Id = 1219371,
                        Code = "48043",
                        Name =
                            "Активационные маркеры, контроль лечения (CD-типирование методом проточной цитометрии) (цельная кровь ? ЭДТА )"
                    },
                    new ServiceType
                    {
                        Id = 1219372,
                        Code = "48044",
                        Name =
                            "Иммунограмма тесты 3 уровня методом проточной цитометрии (расширенная с определением субпопуляций В-лимфоцитов) (кровь (сыворотка) + цельная кровь ? ЭДТА + цельная кровь- Li-гепарин)"
                    },
                    new ServiceType
                    {
                        Id = 1219373,
                        Code = "48045",
                        Name =
                            "Определение аутоимунных субпопуляций В-лимфоцитов (CD-типирование методом проточной цитометрии) (цельная кровь ? ЭДТА )"
                    },
                    new ServiceType {Id = 1219374, Code = "48046", Name = "Микоплазма (Mycoplasma hominis) (соскоб)"},
                    new ServiceType {Id = 1219375, Code = "48047", Name = "Микоплазма (Mycoplasma genitalium) (соскоб)"},
                    new ServiceType {Id = 1219377, Code = "48050", Name = "Иринотекан"},
                    new ServiceType {Id = 1219378, Code = "48051", Name = "Синдром Жильбера"},
                    new ServiceType
                    {
                        Id = 1219379,
                        Code = "48052",
                        Name = "Уридиндифосфатглюкуронидаза (синдром Жильбера)"
                    },
                    new ServiceType {Id = 1219380, Code = "48053", Name = "Синдром Жильбера"},
                    new ServiceType {Id = 1219381, Code = "48054", Name = "Семейный медуллярный рак щитовидной железы"},
                    new ServiceType
                    {
                        Id = 1219382,
                        Code = "48055",
                        Name = "Синдром множественной эндокринной неоплазии 2В типа (МЭН 2В)"
                    },
                    new ServiceType
                    {
                        Id = 1219383,
                        Code = "48056",
                        Name = "Синдром множественной эндокринной неоплазии 2А типа (МЭН 2А)"
                    },
                    new ServiceType {Id = 1219384, Code = "48057", Name = "Лептин"},
                    new ServiceType {Id = 1219385, Code = "48058", Name = "Рецептор меланокортина"},
                    new ServiceType {Id = 1219386, Code = "48059", Name = "Проопиомеланокортин"},
                    new ServiceType {Id = 1219388, Code = "48061", Name = "Периодическая болезнь"},
                    new ServiceType {Id = 1219389, Code = "48062", Name = "ОНКОРИСК женский: шейка матки"},
                    new ServiceType {Id = 1219390, Code = "48063", Name = "Аспирин и плавикс"},
                    new ServiceType {Id = 1219391, Code = "48064", Name = "Варфарин: побочные эффекты"},
                    new ServiceType
                    {
                        Id = 1219392,
                        Code = "48065",
                        Name = "Сульфонилмочевина и ее производные: хлорпропамид, толазамид, глибенкламид и толбутамид"
                    },
                    new ServiceType
                    {
                        Id = 1219393,
                        Code = "48066",
                        Name = "Нестероидные противовоспалительные препараты"
                    },
                    new ServiceType {Id = 1219394, Code = "48067", Name = "Лозартан/ирбесартан"},
                    new ServiceType {Id = 1219395, Code = "48068", Name = "Сульфаниламиды (сульфасалазин)"},
                    new ServiceType {Id = 1219396, Code = "48069", Name = "Изониазид"},
                    new ServiceType {Id = 1219397, Code = "48070", Name = "Гидралазин и прокаинамид"},
                    new ServiceType {Id = 1219398, Code = "48071", Name = "Статины"},
                    new ServiceType {Id = 1219399, Code = "48072", Name = "Атеросклероз"},
                    new ServiceType {Id = 1219400, Code = "48073", Name = "Болезнь Альцгеймера"},
                    new ServiceType {Id = 1219401, Code = "48074", Name = "Непереносимость молока у взрослых людей"},
                    new ServiceType {Id = 1219402, Code = "48075", Name = "Варфарин: эффективность терапии"},
                    new ServiceType {Id = 1219403, Code = "48076", Name = "Цитомегаловирус (Cytomegalovirus)"},
                    new ServiceType
                    {
                        Id = 1219404,
                        Code = "48077",
                        Name = "В ОЖИДАНИИ МАЛЫША: диагностика урогенитальных инфекций"
                    },
                    new ServiceType
                    {
                        Id = 1219406,
                        Code = "48079",
                        Name = "СЕКС В БОЛЬШОМ ГОРОДЕ: 12 инфекций+мазок на флору"
                    },
                    new ServiceType
                    {
                        Id = 1219407,
                        Code = "48080",
                        Name = "СЕКС В БОЛЬШОМ ГОРОДЕ: 7 инфекций+мазок на флору"
                    },
                    new ServiceType
                    {
                        Id = 1219408,
                        Code = "48081",
                        Name = "АТ к фосфатидил-серину IgG+IgM (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1219387, Code = "48060", Name = "Синдром Криглера-Найара"},
                    new ServiceType {Id = 1219410, Code = "48083", Name = "Кандида (Candida albicans) (соскоб)"},
                    new ServiceType
                    {
                        Id = 1219411,
                        Code = "48084",
                        Name =
                            "Определение специфических IgG к 90 наиболее часто встречаемым пищевым аллергенам (IgG antibodies to 90 food allergens in human serum)(кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1219412,
                        Code = "48085",
                        Name = "Установление биологического родства для еще одного ребенка"
                    },
                    new ServiceType
                    {
                        Id = 1219413,
                        Code = "48086",
                        Name =
                            "Ускоренное установление биологического родства для одного из родителей при отсутствии другого (2 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219414,
                        Code = "48087",
                        Name =
                            "Установление биологического родства для одного из родителей при отсутствии другого (2 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219415,
                        Code = "48088",
                        Name =
                            "Срочное установление биологического родства для одного из родителей при отсутствии другого (2 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219416,
                        Code = "48089",
                        Name =
                            "Ускоренное установление биологического родства для одного из родителей при бесспорном родстве другого (3 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219417,
                        Code = "48090",
                        Name =
                            "Установление биологического родства для одного из родителей при бесспорном родстве другого (3 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219418,
                        Code = "48091",
                        Name =
                            "Срочное установление биологического родства для одного из родителей при бесспорном родстве другого (3 чел.)"
                    },
                    new ServiceType
                    {
                        Id = 1219409,
                        Code = "48082",
                        Name = "АТ к цитоплазме нейтрофилов (ANCA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1219419,
                        Code = "48092",
                        Name =
                            "Гастропанель (Helicobacter pylori Ig G; Пепсиноген 1; Гастрин-17) кровь (сыворотка)Взятие материала только в МО ИНВИТРО"
                    },
                    new ServiceType {Id = 1219420, Code = "48093", Name = "ГАСТРОПАНЕЛЬ"},
                    new ServiceType
                    {
                        Id = 1219421,
                        Code = "48094",
                        Name =
                            "Глюкозо-толерантный тест с определением глюкозы и С-пептида в венозной крови натощак и после нагрузки через 2 часа (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType {Id = 1219422, Code = "48095", Name = "Глюкозотолерантный тест"},
                    new ServiceType
                    {
                        Id = 1219423,
                        Code = "48096",
                        Name = "Катехоламины (адреналин, норадреналин, дофамин) в плазме (Симпато-адреналовая система)"
                    },
                    new ServiceType
                    {
                        Id = 1219424,
                        Code = "48097",
                        Name = "Основные эссенциальные (жизненно необходимые) микроэлементы"
                    },
                    new ServiceType {Id = 1219425, Code = "48098", Name = "Большой скрининг элементного состава"},
                    new ServiceType {Id = 1219426, Code = "48099", Name = "Токсичные микроэлементы"},
                    new ServiceType {Id = 1219427, Code = "48100", Name = "Токсичные и эссенциальные микроэлементы"},
                    new ServiceType {Id = 1219428, Code = "48101", Name = "Большой скрининг элементного состава"},
                    new ServiceType {Id = 1219429, Code = "48102", Name = "Токсичные микроэлементы (тяжёлые металлы)"},
                    new ServiceType {Id = 1219430, Code = "48103", Name = "Микроэлементы в сыворотке и цельной крови"},
                    new ServiceType {Id = 1219431, Code = "48104", Name = "Токсичные микроэлементы"},
                    new ServiceType {Id = 1219432, Code = "48105", Name = "Токсичные и эссенциальные микроэлементы"},
                    new ServiceType
                    {
                        Id = 1219433,
                        Code = "48106",
                        Name = "Эссенциальные (жизненно необходимые) и токсичные микроэлементы"
                    },
                    new ServiceType
                    {
                        Id = 1219434,
                        Code = "48107",
                        Name = "Взятие крови в медицинских офисах Лаборатории ИНВИТРО из вены"
                    },
                    new ServiceType
                    {
                        Id = 1219435,
                        Code = "48108",
                        Name = "Взятие крови без последующего исследования (1 пробирка)"
                    },
                    new ServiceType
                    {
                        Id = 1219436,
                        Code = "48109",
                        Name = "Получение сыворотки без последующего исследования (1 пробирка)"
                    },
                    new ServiceType
                    {
                        Id = 1219437,
                        Code = "48110",
                        Name = "Взятие материала для микробиологических исследований"
                    },
                    new ServiceType
                    {
                        Id = 1219438,
                        Code = "48111",
                        Name = "Выдача результатов на английском языке (перевод результатов на английский язык)"
                    },
                    new ServiceType
                    {
                        Id = 1219439,
                        Code = "48112",
                        Name =
                            "Взятие мазка/соскоба мужчинам и женщинам стерильным одноразовым набором,втом числе для ПЦР исследований"
                    },
                    new ServiceType {Id = 1219440, Code = "50010", Name = "TORCH-инфекции"},
                    new ServiceType {Id = 1219441, Code = "50017", Name = "Щитовидная железа: первичное обследование"},
                    new ServiceType {Id = 1219442, Code = "50018", Name = "Щитовидная железа: развернутое обследование"},
                    new ServiceType {Id = 1219443, Code = "50019", Name = "Бытовые аллергены"},
                    new ServiceType {Id = 1219444, Code = "50020", Name = "Аллергия на пищевые продукты"},
                    new ServiceType {Id = 1219445, Code = "50021", Name = "Аллергия на плесневые грибы"},
                    new ServiceType {Id = 1219446, Code = "50023", Name = "Госпитализация в терапевтический стационар"},
                    new ServiceType {Id = 1219447, Code = "50024", Name = "Госпитализация в хирургический стационар"},
                    new ServiceType
                    {
                        Id = 1219448,
                        Code = "50025",
                        Name = "Ежегодное профилактическое лабораторное обследование"
                    },
                    new ServiceType
                    {
                        Id = 1219449,
                        Code = "50029",
                        Name = "В ожидании малыша: 1-й триместр (1-12 неделя беременности)"
                    },
                    new ServiceType {Id = 1219450, Code = "50034", Name = "Молодежный: минимальный"},
                    new ServiceType {Id = 1219451, Code = "50035", Name = "Молодежный: оптимальный"},
                    new ServiceType {Id = 1219452, Code = "50039", Name = "Дамы элегантного возраста"},
                    new ServiceType {Id = 1219453, Code = "50040", Name = "Мужчины 40+"},
                    new ServiceType {Id = 1219454, Code = "50041", Name = "Проблемы веса"},
                    new ServiceType {Id = 1219455, Code = "50042", Name = "АСЛ - О (АСЛО, Антистрептолизин - О,ASO)"},
                    new ServiceType {Id = 1219456, Code = "50043", Name = "С - реактивный белок (СРБ, CRP)"},
                    new ServiceType {Id = 1219457, Code = "50053", Name = "ЛИПИДНЫЙ профиль: рекомендуемый"},
                    new ServiceType {Id = 1219458, Code = "50054", Name = "ЛИПИДНЫЙ профиль: скрининг"},
                    new ServiceType {Id = 1219459, Code = "50057", Name = "Обследование ПЕЧЕНИ: скрининг"},
                    new ServiceType
                    {
                        Id = 1219460,
                        Code = "50058",
                        Name = "Первичное обследование на наличие ГЕПАТИТА (А,В,С)"
                    },
                    new ServiceType {Id = 1219461, Code = "50060", Name = "Обследование ПОЧЕК: рекомендуемое"},
                    new ServiceType {Id = 1219463, Code = "50062", Name = "Диагностика ЦЕЛИАКИИ"},
                    new ServiceType {Id = 1219464, Code = "50063", Name = "БОЛИ В СУСТАВАХ"},
                    new ServiceType {Id = 1219465, Code = "50064", Name = "Профиль РЕВМАТОЛОГИЧЕСКИЙ (скрининг)"},
                    new ServiceType {Id = 1219466, Code = "50065", Name = "Контроль ДИАБЕТА: рекомендуемый"},
                    new ServiceType {Id = 1219467, Code = "50066", Name = "Контроль ДИАБЕТА: минимальный"},
                    new ServiceType {Id = 1219468, Code = "50068", Name = "Диагностика АНЕМИЙ"},
                    new ServiceType {Id = 1219469, Code = "50071", Name = "Диагностика ОСТЕОПОРОЗА"},
                    new ServiceType {Id = 1219470, Code = "50072", Name = "Контроль терапии ОСТЕОПОРОЗА"},
                    new ServiceType {Id = 1219471, Code = "50073", Name = "БИОХИМИЯ крови: расширенный профиль"},
                    new ServiceType {Id = 1219473, Code = "50075", Name = "ЩИТОВИДНАЯ ЖЕЛЕЗА: комплексное обследование"},
                    new ServiceType {Id = 1219474, Code = "50076", Name = "ЩИТОВИДНАЯ ЖЕЛЕЗА: скрининг"},
                    new ServiceType {Id = 1219476, Code = "50078", Name = "Госпитализация в ХИРУРГИЧЕСКИЙ стационар"},
                    new ServiceType
                    {
                        Id = 1219477,
                        Code = "50079",
                        Name = "Ежегодное ПРОФИЛАКТИЧЕСКОЕ лабораторное обследование"
                    },
                    new ServiceType
                    {
                        Id = 1219478,
                        Code = "50080",
                        Name = "ЖЕНСКИЙ ГОРМОНАЛЬНЫЙ профиль (планирование беременности, дисфункция, бесплодие)"
                    },
                    new ServiceType
                    {
                        Id = 1219479,
                        Code = "50081",
                        Name = "Проблемы НЕВЫНАШИВАНИЯ: аутоиммунный профиль"
                    },
                    new ServiceType {Id = 1219480, Code = "50082", Name = "Оценка андрогенного статуса"},
                    new ServiceType {Id = 1219482, Code = "50084", Name = "TORCH-инфекции"},
                    new ServiceType
                    {
                        Id = 1219483,
                        Code = "50085",
                        Name = "В ОЖИДАНИИ МАЛЫША: 1-й триместр (1-12 неделя беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1219484,
                        Code = "50086",
                        Name = "В ОЖИДАНИИ МАЛЫША: 2-й триместр (12-28 неделя беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1219485,
                        Code = "50087",
                        Name =
                            "Hepatitis B surface antigen, HBs - антиген, поверхностный антиген вируса гепатита В, \"австрлийский\" антиген"
                    },
                    new ServiceType {Id = 1219486, Code = "50089", Name = "ЗДОРОВЫЙ РЕБЕНОК: для детей от 0 до 14 лет"},
                    new ServiceType {Id = 1219487, Code = "50090", Name = "ВИЧ, сифилис, гепатит В, С"},
                    new ServiceType {Id = 1219488, Code = "50091", Name = "СЕКС В БОЛЬШОМ ГОРОДЕ: анализ крови"},
                    new ServiceType
                    {
                        Id = 1219489,
                        Code = "50094",
                        Name = "ПРОБЛЕМЫ ВЕСА (первичное обследование здоровья пациентов с нарушениями веса)"
                    },
                    new ServiceType {Id = 1219490, Code = "50099", Name = "Аллергия на пищевые продукты"},
                    new ServiceType {Id = 1219491, Code = "50100", Name = "Аллергия на плесневые грибы"},
                    new ServiceType {Id = 1219492, Code = "50101", Name = "Аллергия на растения"},
                    new ServiceType {Id = 1219493, Code = "50243", Name = "Антитела класса IgG к Borrelia burgdorferi"},
                    new ServiceType {Id = 1219494, Code = "50244", Name = "Антитела к Borrelia burgdorferi IgM"},
                    new ServiceType
                    {
                        Id = 1219495,
                        Code = "50267",
                        Name = "Антитела класса IgG к вирусу клещевого энцефалита"
                    },
                    new ServiceType
                    {
                        Id = 1219496,
                        Code = "50323",
                        Name = "Вирус гепатита С, определение РНК (количественное) (HCV-RNA)"
                    },
                    new ServiceType
                    {
                        Id = 1219497,
                        Code = "50355",
                        Name = "Микробактерии туберкулеза (M/Bovis + M. Tuberculosis), определение ДНК"
                    },
                    new ServiceType
                    {
                        Id = 1219498,
                        Code = "50362",
                        Name =
                            "Вирус гепатита В, определение ДНК (количественное, реагенты F. Hoffmann-La Roche) (HBV-DNA)"
                    },
                    new ServiceType
                    {
                        Id = 1219499,
                        Code = "50369",
                        Name = "Microbacterium tuberculosis (M. Tuberculosis), определение ДНК"
                    },
                    new ServiceType
                    {
                        Id = 1219500,
                        Code = "51202",
                        Name = "МЯС Тест на видоспецифичность мясных продуктов"
                    },
                    new ServiceType
                    {
                        Id = 1219501,
                        Code = "51203",
                        Name = "ГМО Определение (качественное) ГМО, сои и кукурузы в сырье и продуктах питания"
                    },
                    new ServiceType {Id = 1219502, Code = "57261", Name = "Цитохром CYP2C9"},
                    new ServiceType {Id = 1219504, Code = "57691", Name = "Лактазная недостаточность взрослых"},
                    new ServiceType {Id = 1219505, Code = "57802", Name = "Адреногенитальный синдром"},
                    new ServiceType {Id = 1219506, Code = "57821", Name = "Определение резус-фактора"},
                    new ServiceType {Id = 1219507, Code = "57831", Name = "Типирование по трем генам HLA II класса"},
                    new ServiceType {Id = 1218725, Code = "40902", Name = "Каннабиноиды (марихуана) -Моча"},
                    new ServiceType
                    {
                        Id = 1218770,
                        Code = "40665",
                        Name =
                            "Панель разные аллергены (домашняя пыль (клещ Derm. Pteronyssinus), домашняя пыль (клещ Derm. Farinae), ольха, береза, лещина, смесь трав, рожь (пыльца), полынь, подорожник, кошка, лошадь, собака, Alternaria alternate, белок, молоко, арахис, лесной орех, м"
                    },
                    new ServiceType
                    {
                        Id = 1218979,
                        Code = "40319",
                        Name = "Вирус гепатита В, определение ДНК (качественное) (HBV-DNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218980,
                        Code = "40320",
                        Name = "Вирус гепатита В, определение ДНК (количественное) (HBV-DNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218981,
                        Code = "40321",
                        Name = "Вирус гепатита С, определение РНК (качественное) (HCV-RNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218982,
                        Code = "40323",
                        Name = "Вирус гепатита С, определение РНК (количественное) (HCV-RNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218983,
                        Code = "40324",
                        Name = "Вирус гепатита С (генотипирование), определение РНК (HCV-RNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218984,
                        Code = "40325",
                        Name = "Вирус гепатита D, определение РНК (HDV-RNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218985,
                        Code = "40326",
                        Name = "Вирус гепатита G, определение РНК (HDV-RNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218986,
                        Code = "40327",
                        Name = "Вирус ТТ, определение ДНК (ТТ virus DNA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218987,
                        Code = "40328",
                        Name = "Вирус гепатита А, определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218988,
                        Code = "40329",
                        Name = "Микобактерии туберкулёза (M.Bovis+M.Tuberculosis), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218989,
                        Code = "40330",
                        Name = "Микоплазма (Mycoplasma pneumoniae), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218990,
                        Code = "40331",
                        Name = "Стрептококк (Streptococcus pneumoniae), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218991,
                        Code = "40332",
                        Name = "Хламидия (Chlamydia pneumoniae), определение ДНК (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218819,
                        Code = "40062",
                        Name =
                            "Эстрадиол (E2, Estradiol) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218820,
                        Code = "40063",
                        Name =
                            "Прогестерон (Progesterone) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218821,
                        Code = "40064",
                        Name =
                            "Тестостерон (Testosterone) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218822,
                        Code = "40065",
                        Name =
                            "Кортизол (Гидрокортизон, Cortisol) кровь (сыворотка) - Гипофизарно-надпочечниковая система"
                    },
                    new ServiceType
                    {
                        Id = 1218823,
                        Code = "40066",
                        Name =
                            "Хорионический гонадотропин человека (ХГЧ, бета-ХГЧ, б-ХГЧ, Human Chorionic gonadotropin, HCG) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType {Id = 1218824, Code = "40067", Name = "ДИАБЕТ: аутоиммунные маркёры"},
                    new ServiceType
                    {
                        Id = 1218825,
                        Code = "40068",
                        Name = "Антитела к ВИЧ 1 / 2 (anti-HIV) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218826, Code = "40069", Name = "ОНКОРИСК мужской: предстательная железа"},
                    new ServiceType
                    {
                        Id = 1218827,
                        Code = "40070",
                        Name = "Сифилис EIA (IgM+IgG) (Syphlis EIA (IgM+IgG)) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218828,
                        Code = "40071",
                        Name = "anti - HAV IgG (антитела класса IgG к вирусу гепатита А) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218829,
                        Code = "40072",
                        Name = "Anti-HAV-IgM (антитела класса IgM к вирусу гепатита А) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218830,
                        Code = "40073",
                        Name =
                            "HBsAg (HBs-антиген, поверхностный антиген вируса гепатита B, ?австралийский? антиген) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218831,
                        Code = "40074",
                        Name = "HBеAg (HBе-антиген вируса гепатита В) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218832,
                        Code = "40075",
                        Name =
                            "Anti-HBс-total (антитела классов IgM и IgG к HB-core антигену вируса гепатита B) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218833,
                        Code = "40076",
                        Name =
                            "Anti-HBс IgМ (антитела класса IgМ к HB-core-антигену вируса гепатита B) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218834,
                        Code = "40077",
                        Name = "Anti-Hbе (Антитела к HBе-антигену вируса гепатита B) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1221419,
                        Code = "40999",
                        Name = "Исследование пунктатов молочной железы и кожи222"
                    },
                    new ServiceType {Id = 1116161, Code = "16161", Name = "Интерлейкин 1b"},
                    new ServiceType {Id = 1116504, Code = "16504", Name = "Ht (гематокрит)"},
                    new ServiceType {Id = 1116515, Code = "16515", Name = "Лимфоциты (Л)"},
                    new ServiceType {Id = 1116606, Code = "16606", Name = "Белок"},
                    new ServiceType {Id = 1116616, Code = "16616", Name = "Бактерии"},
                    new ServiceType {Id = 1116875, Code = "16875", Name = "Влагалище"},
                    new ServiceType {Id = 1116704, Code = "16704", Name = "Флора"},
                    new ServiceType {Id = 1206110, Code = "", Name = "По видам осмторов"},
                    new ServiceType {Id = 1118103, Code = "18103", Name = "Выдача повторного МСКТ снимка"},
                    new ServiceType {Id = 1204022, Code = "", Name = "Группа 16"},
                    new ServiceType {Id = 1219064, Code = "41074", Name = "Таллий (моча)"},
                    new ServiceType {Id = 1203013, Code = "", Name = "Тепловизорная диагностика"},
                    new ServiceType {Id = 1205014, Code = "", Name = "Функциональная диагностика (невролог)"},
                    new ServiceType {Id = 1218589, Code = "", Name = "ИССЛЕДОВАНИЯ КАЛА"},
                    new ServiceType {Id = 1206117, Code = "", Name = "Водительская"},
                    new ServiceType
                    {
                        Id = 1118013,
                        Code = "18013",
                        Name = "Рентгенография грудино-ключичного сочленения, грудины (2 проекции)"
                    },
                    new ServiceType
                    {
                        Id = 1218605,
                        Code = "",
                        Name = "ОПРЕДЕЛЕНИЕ БИОЛОГИЧЕСКОГО РОДСТВА В СЕМЬЕ: ОТЦОВСТВА И МАТЕРИНСТВА*"
                    },
                    new ServiceType {Id = 1219038, Code = "41008", Name = "Таллий (волосы)"},
                    new ServiceType {Id = 1219058, Code = "41037", Name = "Мышьяк (моча)"},
                    new ServiceType {Id = 1219070, Code = "41080", Name = "Барий (ногти)"},
                    new ServiceType {Id = 1219091, Code = "41101", Name = "Фосфор (ногти)"},
                    new ServiceType {Id = 1219098, Code = "41108", Name = "Олово (ногти)"},
                    new ServiceType {Id = 1219105, Code = "41115", Name = "Марганец - цельная кровь"},
                    new ServiceType {Id = 1218760, Code = "40654", Name = "F84 киви IgE"},
                    new ServiceType {Id = 1218766, Code = "40660", Name = "E6 морская свинка эпителий IgE"},
                    new ServiceType {Id = 1218776, Code = "40018", Name = "Гликированный гемоглобин"},
                    new ServiceType {Id = 1219131, Code = "41141", Name = "Ртуть - цельная кровь"},
                    new ServiceType {Id = 1219197, Code = "46655", Name = "F3 треска IgG"},
                    new ServiceType {Id = 1219204, Code = "46662", Name = "F75 яичный желток IgG"},
                    new ServiceType
                    {
                        Id = 1219230,
                        Code = "47841",
                        Name =
                            "Исследование мутаций в гене Витамин К- эпоксид-редуктазного комплекса, субъединица 1 (VKORC1) (1 чел.)"
                    },
                    new ServiceType {Id = 1219462, Code = "50061", Name = "Обследование ПОЧЕК: скрининг"},
                    new ServiceType {Id = 1219503, Code = "57661", Name = "Нарушения сперматогенеза"},
                    new ServiceType
                    {
                        Id = 1218728,
                        Code = "40622",
                        Name = "Клещ Dermatophagoides farinae (кровь (сыворотка)) (Определение специфичесиких IgE)"
                    },
                    new ServiceType
                    {
                        Id = 1219139,
                        Code = "41204",
                        Name =
                            "Антитела к циклическому цитруллинированному пептиду (АЦЦП, cyclic citrullinated peptide antibodies , anti-CCP, CCP)"
                    },
                    new ServiceType
                    {
                        Id = 1218884,
                        Code = "40163",
                        Name =
                            "Натриуретического гормона (В-типа) N-концевой пропептид (NT-proBNP, N-terminal pro-brain natriuretic peptide, pro-B-type natriuretic peptide) -Плазма (гепарин) (Гормональная система регуляции обмена натрия и воды)"
                    },
                    new ServiceType
                    {
                        Id = 1218885,
                        Code = "40165",
                        Name = "Кальций ионизированный (Ca++, Calcium ionized) - плазма крови"
                    },
                    new ServiceType
                    {
                        Id = 1218886,
                        Code = "40166",
                        Name = "Cа 72-4 (Углеводный антиген 72-4, CA 72-4) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218887,
                        Code = "40167",
                        Name = "Cyfra-21-1(Фрагмент Цитокератина 19) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218879,
                        Code = "40154",
                        Name =
                            "17-ОН прогестерон (17-ОП) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218888,
                        Code = "40168",
                        Name =
                            "Дигидротестостерон (DHT, Dihydrotestosterone) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218889,
                        Code = "40169",
                        Name =
                            "Свободный тестостерон (Free Testosterone) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218890,
                        Code = "40170",
                        Name =
                            "Андростендиол глюкуронид (Androstanediol glucuronide , 3-alpha-diol-G) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218891,
                        Code = "40171",
                        Name = "Кальцитонин (Calcitonin) (кровь (сыворотка)) Функция паращитовидных желез"
                    },
                    new ServiceType
                    {
                        Id = 1218892,
                        Code = "40172",
                        Name =
                            "Инсулин (Insulin) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218893,
                        Code = "40173",
                        Name =
                            "Проинсулин (Proinsulin) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218894,
                        Code = "40174",
                        Name =
                            "Соматомедин-С (Инсулиноподобный фактор роста I , ИФР-1; Insulin-like growth factor I, IGF-1) (кровь (сыворотка)) (Соматотропная функция гипофиза)"
                    },
                    new ServiceType {Id = 1218895, Code = "40175", Name = "Лептин (Leptin) кровь"},
                    new ServiceType
                    {
                        Id = 1218896,
                        Code = "40178",
                        Name =
                            "Свободный кортизол (в моче) (Free cortisol, urine) (суточная моча) - Гипофизарно-надпочечниковая система"
                    },
                    new ServiceType
                    {
                        Id = 1218897,
                        Code = "40183",
                        Name =
                            "Anti-Сhlamydia pneum.-IgA (антитела класса IgA к Chlamydia pneumoniae) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218898,
                        Code = "40184",
                        Name =
                            "Anti-Сhlamydia pneum.-IgM (антитела класса IgM к Chlamydia pneumoniae) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218899,
                        Code = "40185",
                        Name =
                            "Anti-Сhlamydia pneum.-IgG (антитела класса IgG к Chlamydia pneumoniae) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218900,
                        Code = "40186",
                        Name = "Epstein-Barr Virus IgM к VCA (капсидному антигену) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218901,
                        Code = "40187",
                        Name = "Epstein-Barr Virus IgG к NA (нуклеарному антигену) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218902,
                        Code = "40188",
                        Name =
                            "Anti-Сhlamydia tr.-IgM (антитела класса IgM к Chlamydia trachomatis c указанием титра) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218903,
                        Code = "40189",
                        Name =
                            "Свободная b-субъединица хорионического гонадотропина человека (свободный b-ХГЧ, free b-HCG) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218904,
                        Code = "40190",
                        Name = "Волчаночный антикоагулянт(Lupus anticoagulants, LA)"
                    },
                    new ServiceType
                    {
                        Id = 1218905,
                        Code = "40193",
                        Name = "Компоненты системы комплемента С3,С4 (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218906, Code = "40194", Name = "Тромбиновое время"},
                    new ServiceType
                    {
                        Id = 1218907,
                        Code = "40195",
                        Name =
                            "Андростендион (Androstenedione) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218908,
                        Code = "40196",
                        Name =
                            "T-Uptake (Тироксин связывающая способность сыворотки или плазмы человека; Thyroid uptake)(кровь (сыворотка)) (Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218909,
                        Code = "40197",
                        Name = "ТГ (Tиреоглобулин; Thyroglobulin, TG) (кровь (сыворотка))(Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218910,
                        Code = "40198",
                        Name =
                            "АТ-МАГ( антитела к микросомальной фракции тироцито, антимикросомальные антитела, Antimicrosomal antibody)(кровь (сыворотка)) (Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218911,
                        Code = "40199",
                        Name =
                            "АТ к рТТГ (антитела к рецепторам ТТГ, TSH receptor autoantibodies) (кровь (сыворотка))(Функция щитовидной железы)"
                    },
                    new ServiceType
                    {
                        Id = 1218912,
                        Code = "40200",
                        Name =
                            "АТ к инсулину (Anti-Insulin antibodies) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218913,
                        Code = "40201",
                        Name =
                            "АТ к бета-клеткам поджелудочной железы (Anti-Islet Cell antibodies) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218914,
                        Code = "40202",
                        Name =
                            "АТ-GAD (антитела к глутаматдекарбоксилазе, GAD-autoantibodies) (кровь (сыворотка)) (Функция поджелудочной железы и диагностика диабета)"
                    },
                    new ServiceType
                    {
                        Id = 1218915,
                        Code = "40203",
                        Name =
                            "?-Cross laps (С-концевые телопептиды коллагена I типа, продукт деградации коллагена в результате костной резобции)"
                    },
                    new ServiceType
                    {
                        Id = 1218916,
                        Code = "40204",
                        Name =
                            "Маркер формирования костного матрикса P1NP (N-терминальный пропептид проколлагена 1 типа, Total P1NP)"
                    },
                    new ServiceType
                    {
                        Id = 1218917,
                        Code = "40205",
                        Name = "Альдостерон (Aldosterone) кровь (Гормональная система регуляции обмена натрия и воды)"
                    },
                    new ServiceType
                    {
                        Id = 1218918,
                        Code = "40206",
                        Name = "Ренин (ReninI) плазма (Гормональная система регуляции обмена натрия и воды)"
                    },
                    new ServiceType
                    {
                        Id = 1218919,
                        Code = "40207",
                        Name =
                            "Плацентарный лактоген (Human placental lactogen, HPL) (кровь (сыворотка)) (Состояние репродуктивной системы и мониторинг беременности)"
                    },
                    new ServiceType
                    {
                        Id = 1218920,
                        Code = "40208",
                        Name = "?2-микроглобулин (в крови) (Beta-2 microglobulin, serum) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218921,
                        Code = "40209",
                        Name = "Нейро-специфическая енолаза (Neuron-specific enolase NSE) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218922, Code = "40210", Name = "Интерлейкин 1 ? (IL-1?) (кровь (сыворотка))"},
                    new ServiceType {Id = 1218923, Code = "40211", Name = "Интерлейкин 6 (IL ? 6) (кровь (сыворотка))"},
                    new ServiceType {Id = 1218924, Code = "40212", Name = "Интерлейкин 8 (IL ? 8) (кровь (сыворотка))"},
                    new ServiceType {Id = 1218925, Code = "40213", Name = "Интерлейкин 10 (IL -10) (кровь (сыворотка))"},
                    new ServiceType
                    {
                        Id = 1218926,
                        Code = "40214",
                        Name = "ФНО (фактор некроза опухоли, Tumor necrosis factor ?, TNF ?) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218927, Code = "40216", Name = "Гастрин (Gastrin) кровь"},
                    new ServiceType
                    {
                        Id = 1218928,
                        Code = "40218",
                        Name =
                            "Фракция холестерина ОНП (ЛПНОНП, Холестерол липопротеинов очень низкой плотности, VLDL Cholesterol)"
                    },
                    new ServiceType {Id = 1218930, Code = "40220", Name = "Аполипопротеин В (Apolipoprotein B)"},
                    new ServiceType
                    {
                        Id = 1218931,
                        Code = "40221",
                        Name =
                            "Антитела класса IgM к Treponema pallidum (anti-Treponema pallidum IgM) (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218932, Code = "40222", Name = "Эритропоэтин (Erythropoetin) кровь"},
                    new ServiceType
                    {
                        Id = 1218933,
                        Code = "40223",
                        Name = "Антиспермальные АТ (в крови) (Anti-Spematozoa antibody, serum)"
                    },
                    new ServiceType
                    {
                        Id = 1218934,
                        Code = "40224",
                        Name = "Антиспермальные АТ (в сперме) (Anti-Spematozoa antibody, seminal plazma)"
                    },
                    new ServiceType
                    {
                        Id = 1218935,
                        Code = "40225",
                        Name = "?2-микроглобулин (в моче) (Beta-2 microglobulin, urine) моча"
                    },
                    new ServiceType
                    {
                        Id = 1218936,
                        Code = "40227",
                        Name = "Anti-HEV-IgM (Антитела класса IgM к вирусу гепатита Е) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218937,
                        Code = "40228",
                        Name = "Anti-HEV-IgG (Антитела класса IgG к вирусу гепатита Е) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218938,
                        Code = "40229",
                        Name = "Анти-Эхинококк-IgG (антитела класса IgG к антигенам эхинококка) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218939,
                        Code = "40233",
                        Name = "Антитела класса IgG к антигенам трихинелл (anti-Trichinella IgG) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218940,
                        Code = "40235",
                        Name =
                            "Антитела класса IgG к Entamoeba histolitica (anti-Entamoeba histolitica IgG) кровь (сыворотка)"
                    },
                    new ServiceType {Id = 1218941, Code = "40236", Name = "Содержание углеводов в кале"},
                    new ServiceType {Id = 1218929, Code = "40219", Name = "Аполипопротеин А1 (Apolipoprotein A-1)"},
                    new ServiceType
                    {
                        Id = 1218942,
                        Code = "40238",
                        Name =
                            "Антитела класса IgA к антигенам Yersinia Enterocolitica (Аnti-Yersinia Enterocolitica IgA) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218943,
                        Code = "40239",
                        Name =
                            "Антитела класса IgG к антигенам Yersinia Enterocolitica (Аnti-Yersinia Enterocolitica IgG) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218944,
                        Code = "40241",
                        Name = "Антитела класса IgG к Аденовирусу (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218945,
                        Code = "40242",
                        Name = "Антитела класса IgA к Аденовирусу (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218946,
                        Code = "40243",
                        Name = "Антитела класса IgG к Borrelia burgdorferi (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218947,
                        Code = "40244",
                        Name = "Антитела к Borrelia burgdorferi IgM (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218948,
                        Code = "40245",
                        Name = "Антитела класса IgG Bortedella pertusis (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218949,
                        Code = "40246",
                        Name = "Антитела класса IgM к Bortedella pertusis (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218950,
                        Code = "40247",
                        Name = "Антитела класса IgA к Bortedella pertusis (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218951,
                        Code = "40248",
                        Name = "Антитела класса IgG к Respiratory syncyt. vir. (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218952,
                        Code = "40249",
                        Name = "Антитела класса IgM к Respiratory syncyt. vir. (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218953,
                        Code = "40250",
                        Name = "Антитела класса IgG к вирусу кори (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218954,
                        Code = "40251",
                        Name = "Антитела класса IgM к вирусу кори (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218955,
                        Code = "40252",
                        Name = "Антитела класса IgG к вирусу эпидемического паротита (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218956,
                        Code = "40253",
                        Name = "Антитела класса IgM к вирусу эпидемического паротита (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218957,
                        Code = "40254",
                        Name = "Антитела класса IgG к кандида (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218958,
                        Code = "40256",
                        Name =
                            "Антитела класса IgG к вирусу Varicella-Zoster (Varicella-Zoster Virus IgG, anti-VZV IgG, антитела класса IgG к вирусу ветряной оспы и опоясывающего лишая (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218959,
                        Code = "40257",
                        Name =
                            "Антитела класса IgM к вирусу Varicella-Zoster (Varicella-Zoster Virus IgM, anti-VZV IgM, антитела класса IgM к вирусу ветряной оспы и опоясывающего лишая)(кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218960,
                        Code = "40258",
                        Name = "Антитела к Helicobacter pyl. IgG (блот) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218961,
                        Code = "40259",
                        Name = "Антитела к Helicobacter pyl. IgА (блот) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218962,
                        Code = "40260",
                        Name = "Антитела класса IgA к Mycoplasma hominis (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218963,
                        Code = "40261",
                        Name = "Антитела класса IgG к Trichomonas vaginalis (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218964,
                        Code = "40267",
                        Name = "Антитела класса IgG к вирусу клещевого энцефалита (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218965,
                        Code = "40268",
                        Name = "Антитела класса IgM к вирусу клещевого энцефалита (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218966,
                        Code = "40270",
                        Name = "Антитела класса IgG к глиадину (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218967,
                        Code = "40271",
                        Name = "Антитела класса IgA к глиадину (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218968,
                        Code = "40273",
                        Name = "АТ к возбудителю брюшного тифа (Salmonella typhi) (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218969,
                        Code = "40274",
                        Name = "Циклоспорин (Cyclosporine, Cyclosporine A, Sandimmune) цельная кровь (ЭДТА)"
                    },
                    new ServiceType
                    {
                        Id = 1218970,
                        Code = "40275",
                        Name =
                            "АТ класса IgG к капсидному антигену вируса Эпштейн-Барр (anti- Epstein-Barr viral capsid antigens IgG, EBV VCA IgG) кровь (сыворотка)"
                    },
                    new ServiceType
                    {
                        Id = 1218971,
                        Code = "40276",
                        Name = "Антитела к герпес-вирусу 6 типа IgG (кровь (сыворотка))"
                    },
                    new ServiceType
                    {
                        Id = 1218972,
                        Code = "40277",
                        Name = "Антитела к герпес-вирусу 8 типа IgG (кровь (сыворотка))"
                    },
                    new ServiceType {Id = 1218973, Code = "40304", Name = "Influenza virus A/H1 - swine"},
                    new ServiceType
                    {
                        Id = 1218974,
                        Code = "40314",
                        Name =
                            "Герпесвирус I типа (Herpes simplex virus I), определение ДНК (HSV-1 DNA) (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218975,
                        Code = "40315",
                        Name =
                            "Герпесвирус II типа (Herpes simplex virus II), определение ДНК (HSV-2 DNA) (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218976,
                        Code = "40316",
                        Name = "Герпесвирус VI (Human herpes virus VI), определение ДНК (HSV-6 DNA) (цельная кровь)"
                    },
                    new ServiceType
                    {
                        Id = 1218977,
                        Code = "40317",
                        Name = "Цитомегаловирус, определение ДНК (Cytomegalovirus, CMV DNA)"
                    },
                    new ServiceType
                    {
                        Id = 1218978,
                        Code = "40318",
                        Name =
                            "Вирус Эпштейна ? Барр, определение ДНК (Epstein - Barr virus, EBV DNA) кровь (сыворотка)"
                    },
                    new ServiceType {Id = 716, Code = "28001", Name = "В/ венная инъекция препарата"},
                    new ServiceType
                    {
                        Id = 723,
                        Code = "28008",
                        Name =
                            "1 койко-день дневного стационара (со стоимостью  медикаментов, без учета стоимости других подразделений) по ДМС"
                    },
                    new ServiceType {Id = 727, Code = "28012", Name = "В/ венная инъекция  препаратов на дому"},
                    new ServiceType
                    {
                        Id = 729,
                        Code = "28014",
                        Name = "Провокация препаратом ?Пирогенал? внутримышечная"
                    },
                    new ServiceType {Id = 730, Code = "28015", Name = "В/венное введение урографина"},
                    new ServiceType {Id = 1219063, Code = "41071", Name = "Липопротеин (a) (Lipoprotein (a), Lp(a))"},
                    new ServiceType {Id = 1219106, Code = "41116", Name = "Никель - цельная кровь"},
                    new ServiceType {Id = 1218696, Code = "40673", Name = "Баранина IgE"},
                    new ServiceType {Id = 1219312, Code = "47983", Name = "Обмен фолиевой кислоты"},
                    new ServiceType {Id = 1219130, Code = "41140", Name = "Цирконий (волосы)"},
                    new ServiceType {Id = 1219153, Code = "46611", Name = "FP50(киви,манго,банан,ананас) IgG"},
                    new ServiceType {Id = 1219194, Code = "46652", Name = "F24 креветки IgG"},
                    new ServiceType {Id = 1219213, Code = "46671", Name = "Банан IgG"},
                    new ServiceType {Id = 1219265, Code = "47934", Name = "Сурьма(волосы,ногти)"},
                    new ServiceType {Id = 1219376, Code = "48049", Name = "Диагностика аутоиммунного ГЕПАТИТА"},
                    new ServiceType {Id = 1219472, Code = "50074", Name = "БИОХИМИЯ крови: минимальный профиль"},
                    new ServiceType {Id = 1220319, Code = "88888", Name = "Врачебная комиссия"},
                    new ServiceType
                    {
                        Id = 1125001,
                        Code = "25001",
                        Name = "Профилактический прием (осмотр, консультация) врача-терапевта"
                    },
                    new ServiceType {Id = 1117000, Code = "17000", Name = "Иммунологические исследования"},
                    new ServiceType {Id = 1111012, Code = "11012", Name = "Электроэнцефалография"},
                    new ServiceType {Id = 1116164, Code = "16164", Name = "Интерлейкин 6"},
                    new ServiceType {Id = 1123027, Code = "23027", Name = "Ложка индивидуальная"},
                    new ServiceType {Id = 1115006, Code = "15006", Name = "Кольпоскопия"},
                    new ServiceType {Id = 1116511, Code = "16511", Name = "Миелоциты (Мц)"},
                    new ServiceType {Id = 1206113, Code = "", Name = "По сан. книжке (перв. жен.)"},
                    new ServiceType {Id = 1123029, Code = "23029", Name = "Кламмер денто-альвеолярный"},
                    new ServiceType {Id = 1114006, Code = "14006", Name = "Удаление ушной серы"},
                    new ServiceType {Id = 1206118, Code = "", Name = "При устройстве на работу"},
                    new ServiceType {Id = 1218587, Code = "", Name = "ИНФЕКЦИИ"},
                    new ServiceType {Id = 1219021, Code = "40969", Name = "АТ к кардиолипину IgG (кровь (сыворотка))"},

                };
            }
        }


    }
}
