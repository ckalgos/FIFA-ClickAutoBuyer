using FIFAAutoBuyer_Client.Models;
using System.Collections.Generic;
using System.Linq;

namespace FIFAAutoBuyer_Client.Helpers
{
    public static class DropDownHelper
    {
        private static List<DropDownOption> _qualities;
        private static List<DropDownOption> _rarities;
        private static List<DropDownOption> _leagues;
        private static List<DropDownOption> _clubs;

        static DropDownHelper()
        {
            _qualities = GetQualities_Private();
            _rarities = GetRarities_Private();
            _leagues = GetLeagues_Private();
            _clubs = GetClubs_Private();
        }

        public static List<DropDownOption> GetQualities(int? filterId = null)
        {
            return FilterOptionsById(_qualities, filterId);
        }

        public static List<DropDownOption> GetRarities(int? filterId = null)
        {
            return FilterOptionsById(_rarities, filterId);
        }

        public static List<DropDownOption> GetLeagues(int? filterId = null)
        {
            return FilterOptionsById(_leagues, filterId);
        }

        public static List<DropDownOption> GetClubs(int? filterId = null)
        {
            return FilterOptionsById(_clubs, filterId);
        }

        private static List<DropDownOption> FilterOptionsById(List<DropDownOption> options, int? filterId = null)
        {
            if (filterId == null || filterId == -1)
            {
                return options;
            }

            return options.Where(a => a.Id == -1 || a.ParentId?.Contains(filterId.Value) == true).ToList() ?? new List<DropDownOption>();
        }

        private static List<DropDownOption> GetQualities_Private()
        {
            return new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- Quality --" },
              new DropDownOption{ Id = 1,DisplayValue =  "Bronze"},
              new DropDownOption{ Id = 2,DisplayValue ="Silver" },
              new DropDownOption{ Id = 3,DisplayValue ="Gold" },
              new DropDownOption{ Id = 4,DisplayValue ="Special" }
            };
        }

        private static List<DropDownOption> GetRarities_Private()
        {
            return new List<DropDownOption>
            {
              new DropDownOption{ Id = -1 , DisplayValue = "-- Rarity --" },
              new DropDownOption{ Id = 1, ParentId = new HashSet<int>{ 1,2,3 },  DisplayValue =  "Common"},
              new DropDownOption{ Id = 2, ParentId = new HashSet<int>{ 1,2,3},  DisplayValue ="Rare" },
              new DropDownOption{ Id = 3, ParentId = new HashSet<int>{ 4 },  DisplayValue ="CONMEBOL LIBERTADORES" },
              new DropDownOption{ Id = 4, ParentId = new HashSet<int>{ 4 },DisplayValue ="CONMEBOL SUDAMERICANA" },
              new DropDownOption{ Id = 1, ParentId = new HashSet<int>{ 4 },DisplayValue =  "Ones to Watch"},
              new DropDownOption{ Id = 2, ParentId = new HashSet<int>{ 4 },DisplayValue ="RULEBREAKERS" },
              new DropDownOption{ Id = 3, ParentId = new HashSet<int>{ 1,2,3,4 },DisplayValue ="Team of the Week" },
              new DropDownOption{ Id = 4, ParentId = new HashSet<int>{ 4 },DisplayValue ="UEFA Champions League Common" },
              new DropDownOption{ Id = 1, ParentId = new HashSet<int>{ 4 },DisplayValue =  "UEFA Champions League Rare"},
              new DropDownOption{ Id = 2, ParentId = new HashSet<int>{ 4 },DisplayValue ="UEFA Champions League Road to the Final" },
              new DropDownOption{ Id = 3, ParentId = new HashSet<int>{ 4 },DisplayValue ="UEFA CHAMPIONS LEAGUE TEAM OF THE TOURNAMENT" },
              new DropDownOption{ Id = 4, ParentId = new HashSet<int>{ 4 },DisplayValue ="UEFA Europa League Road to the Final" },
              new DropDownOption{ Id = 1, ParentId = new HashSet<int>{ 4 },DisplayValue =  "UEFA EUROPA LEAGUE TEAM OF THE TOURNAMENT"},
            };
        }

        private static List<DropDownOption> GetLeagues_Private()
        {
            return new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- League --" },
              new DropDownOption{ Id = 1, DisplayValue =  "Premier League (ENG 1)"},
              new DropDownOption{ Id = 2, DisplayValue ="EFL Championship (ENG 2)" },
              new DropDownOption{ Id = 3, DisplayValue ="EFL League One (ENG 3)" },
              new DropDownOption{ Id = 4, DisplayValue ="EFL League Two (ENG 4)" },
              new DropDownOption{ Id = 5, DisplayValue =  "Ligue 1 Uber Eats (FRA 1)"},
              new DropDownOption{ Id = 6, DisplayValue ="Ligue 2 BKT (FRA 2)" },
              new DropDownOption{ Id = 7, DisplayValue ="Serie A TIM (ITA 1)" },
              new DropDownOption{ Id = 8, DisplayValue ="Calcio B (ITA 2)" },
              new DropDownOption{ Id = 9, DisplayValue =  "Bundesliga (GER 1)"},
              new DropDownOption{ Id = 10, DisplayValue ="Bundesliga 2 (GER 2)" },
              new DropDownOption{ Id = 11, DisplayValue ="3. Liga (GER 3)" },
              new DropDownOption{ Id = 12, DisplayValue ="LaLiga Santander (ESP 1)" },
              new DropDownOption{ Id = 13, DisplayValue =  "LaLiga SmartBank (ESP 2)"},
              new DropDownOption{ Id = 14, DisplayValue =  "1A Pro League (BEL 1)"},
              new DropDownOption{ Id = 15, DisplayValue ="3F Superliga (DEN 1)" },
              new DropDownOption{ Id = 16, DisplayValue ="A-League (AUS 1)" },
              new DropDownOption{ Id = 17, DisplayValue ="Allsvenskan (SWE 1)" },
              new DropDownOption{ Id = 18, DisplayValue =  "CSL (CHN 1)"},
              new DropDownOption{ Id = 19, DisplayValue =  "Eliteserien (NOR 1)"},
              new DropDownOption{ Id = 20, DisplayValue ="Eredivisie (NED 1)" },
              new DropDownOption{ Id = 21, DisplayValue ="Finnliiga (FIN 1)" },
              new DropDownOption{ Id = 22, DisplayValue ="Hellas Liga (GRE 1)" },
              new DropDownOption{ Id = 23, DisplayValue =  "Icons (ICN)"},
              new DropDownOption{ Id = 24, DisplayValue ="K League 1 (KOR 1)" },
              new DropDownOption{ Id = 25, DisplayValue ="League of Russia (RUS 1)" },
              new DropDownOption{ Id = 26, DisplayValue ="Libertadores (LIB)" },
              new DropDownOption{ Id = 27, DisplayValue =  "LIGA BBVA MX (MEX 1)"},
              new DropDownOption{ Id = 28, DisplayValue ="Liga do Brasil (BRA 1)" },
              new DropDownOption{ Id = 29, DisplayValue ="Liga Hrvatska (CRO 1)" },
              new DropDownOption{ Id = 30, DisplayValue ="Liga I (ROM 1)" },
              new DropDownOption{ Id = 31, DisplayValue =  "Liga NOS (POR 1)"},
              new DropDownOption{ Id = 32, DisplayValue =  "MBS Pro League (SAU 1)"},
              new DropDownOption{ Id = 33, DisplayValue ="Meiji Yasuda J1 (JPN 1)" },
              new DropDownOption{ Id = 34, DisplayValue ="Men's National (INT)" },
              new DropDownOption{ Id = 35, DisplayValue ="MLS (MLS)" },
              new DropDownOption{ Id = 36, DisplayValue =  "PKO Ekstraklasa (POL 1)"},
              new DropDownOption{ Id = 37, DisplayValue ="Primera División (ARG 1)" },
              new DropDownOption{ Id = 38, DisplayValue ="RSL (SUI 1)" },
              new DropDownOption{ Id = 39, DisplayValue ="Scottish Prem (SPFL)" },
              new DropDownOption{ Id = 40, DisplayValue =  "South African FL (RSA 1)"},
              new DropDownOption{ Id = 41, DisplayValue ="SSE Airtricity Lge (IRL 1)" },
              new DropDownOption{ Id = 42, DisplayValue ="Sudamericana (SUD)" },
              new DropDownOption{ Id = 43, DisplayValue ="Süper Lig (TUR 1)" },
              new DropDownOption{ Id = 44, DisplayValue =  "Ukrayina Liha (UKR 1)"},
              new DropDownOption{ Id = 45, DisplayValue ="United Emirates League (UAE 1)" },
              new DropDownOption{ Id = 46, DisplayValue ="Ö. Bundesliga (AUT 1)" },
              new DropDownOption{ Id = 47, DisplayValue ="Česká Liga (CZE 1)" },
            };
        }

        private static List<DropDownOption> GetClubs_Private()
        {
            return new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- Clubs --" },
              new DropDownOption{ Id = 1, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Arsenal"},
              new DropDownOption{ Id = 2, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Aston Villa"},
              new DropDownOption{ Id = 3, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Chelsea"},
              new DropDownOption{ Id = 4, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Everton"},
              new DropDownOption{ Id = 5, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Leeds United"},
              new DropDownOption{ Id = 6, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Liverpool"},
              new DropDownOption{ Id = 7, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Manchester City"},
              new DropDownOption{ Id = 8, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Manchester Utd"},
              new DropDownOption{ Id = 9, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Newcastle Ut"},
              new DropDownOption{ Id = 10, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Southampton"},
              new DropDownOption{ Id = 11, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Spurs"},
              new DropDownOption{ Id = 12, ParentId = new HashSet<int> { 1 }, DisplayValue =  "West Ham"},
              new DropDownOption{ Id = 13, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Leicester City"},
              new DropDownOption{ Id = 14, ParentId = new HashSet<int> { 1 }, DisplayValue =  "West Brom"},
              new DropDownOption{ Id = 15, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Wolves"},
              new DropDownOption{ Id = 16, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Fulham"},
              new DropDownOption{ Id = 17, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Sheffield Utd"},
              new DropDownOption{ Id = 18, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Burnley"},
              new DropDownOption{ Id = 19, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Crystal Palace"},
              new DropDownOption{ Id = 20, ParentId = new HashSet<int> { 1 }, DisplayValue =  "Brighton"},

              new DropDownOption{ Id = 21, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Blackburn Rovers"},
              new DropDownOption{ Id = 22, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Middlesbrough"},
              new DropDownOption{ Id = 23, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Nott'm Forest"},
              new DropDownOption{ Id = 24, ParentId = new HashSet<int> { 2 }, DisplayValue =  "QPR"},
              new DropDownOption{ Id = 25, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Birmingham City"},
              new DropDownOption{ Id = 26, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Derby County"},
              new DropDownOption{ Id = 27, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Millwall"},
              new DropDownOption{ Id = 28, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Norwich"},
              new DropDownOption{ Id = 29, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Reading"},
              new DropDownOption{ Id = 30, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Watford"},
              new DropDownOption{ Id = 31, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Rotherham Utd"},
              new DropDownOption{ Id = 32, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Coventry City"},
              new DropDownOption{ Id = 33, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Preston"},
              new DropDownOption{ Id = 34, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Stoke City"},
              new DropDownOption{ Id = 35, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Sheffield Wed"},
              new DropDownOption{ Id = 36, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Bristol City"},
              new DropDownOption{ Id = 37, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Luton Town"}, 
              new DropDownOption{ Id = 31, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Rotherham Utd"},
              new DropDownOption{ Id = 38, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Brentford"},
              new DropDownOption{ Id = 39, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Barnsley"},
              new DropDownOption{ Id = 40, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Wycombe"},
              new DropDownOption{ Id = 41, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Huddersfield"},
              new DropDownOption{ Id = 42, ParentId = new HashSet<int> { 2 }, DisplayValue =  "AFC Bournemouth"},
              new DropDownOption{ Id = 43, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Swansea City"},
              new DropDownOption{ Id = 44, ParentId = new HashSet<int> { 2 }, DisplayValue =  "Cardiff City"},

              new DropDownOption{ Id = 45, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Charlton Ath"},
              new DropDownOption{ Id = 46, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Ipswich"},
              new DropDownOption{ Id = 47, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Sunderland"},
              new DropDownOption{ Id = 48, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Crewe Alexandra"},
              new DropDownOption{ Id = 49, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Shrewsbury"},
              new DropDownOption{ Id = 50, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Doncaster"},
              new DropDownOption{ Id = 51, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Lincoln City"},
              new DropDownOption{ Id = 52, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Portsmouth"},
              new DropDownOption{ Id = 53, ParentId = new HashSet<int> { 3 }, DisplayValue =  "MK Dons"},
              new DropDownOption{ Id = 54, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Gillingham"},
              new DropDownOption{ Id = 55, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Wigan Athletic"},
              new DropDownOption{ Id = 56, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Blackpool"},
              new DropDownOption{ Id = 57, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Plymouth"},
              new DropDownOption{ Id = 58, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Argyle"},
              new DropDownOption{ Id = 59, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Northampton"},
              new DropDownOption{ Id = 60, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Swindon Town"},
              new DropDownOption{ Id = 61, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Peterborough"}, 
              new DropDownOption{ Id = 62, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Oxford United"},
              new DropDownOption{ Id = 63, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Hull City"},
              new DropDownOption{ Id = 64, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Rochdale"},
              new DropDownOption{ Id = 65, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Bristol Rovers"},
              new DropDownOption{ Id = 66, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Burton Albion"},
              new DropDownOption{ Id = 67, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Accrington"},
              new DropDownOption{ Id = 68, ParentId = new HashSet<int> { 3 }, DisplayValue =  "AFC Wimbledon"},
              new DropDownOption{ Id = 69, ParentId = new HashSet<int> { 3 }, DisplayValue =  "Fleetwood Town"},

              new DropDownOption{ Id = 70, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Bolton"},
              new DropDownOption{ Id = 71, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Grimsby Town"},
              new DropDownOption{ Id = 72, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Exeter City"},
              new DropDownOption{ Id = 73, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Morecambe"},
              new DropDownOption{ Id = 74, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Stevenage"},
              new DropDownOption{ Id = 75, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Barrow"},
              new DropDownOption{ Id = 76, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Forest Green"},
              new DropDownOption{ Id = 77, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Carlisle United"},
              new DropDownOption{ Id = 78, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Walsall"},
              new DropDownOption{ Id = 79, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Bradford City"},
              new DropDownOption{ Id = 80, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Oldham Athletic"},
              new DropDownOption{ Id = 81, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Port Vale"},
              new DropDownOption{ Id = 82, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Colchester"},
              new DropDownOption{ Id = 83, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Cheltenham Town"},
              new DropDownOption{ Id = 84, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Mansfield Town"},
              new DropDownOption{ Id = 85, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Cambridge Utd"},
              new DropDownOption{ Id = 86, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Scunthorpe Utd"},
              new DropDownOption{ Id = 87, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Southend United"},
              new DropDownOption{ Id = 88, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Leyton Orient"},
              new DropDownOption{ Id = 89, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Tranmere Rovers"},
              new DropDownOption{ Id = 90, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Crawley Town"},
              new DropDownOption{ Id = 91, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Harrogate Town"},
              new DropDownOption{ Id = 92, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Newport County"},
              new DropDownOption{ Id = 93, ParentId = new HashSet<int> { 4 }, DisplayValue =  "Salford City"},

              new DropDownOption{ Id = 94, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Bordeaux"},
              new DropDownOption{ Id = 95, ParentId = new HashSet<int> { 5 }, DisplayValue =  "RC Lens"},
              new DropDownOption{ Id = 96, ParentId = new HashSet<int> { 5 }, DisplayValue =  "LOSCOL"},
              new DropDownOption{ Id = 97, ParentId = new HashSet<int> { 5 }, DisplayValue =  "FC Metz"},
              new DropDownOption{ Id = 98, ParentId = new HashSet<int> { 5 }, DisplayValue =  "AS Monaco"},
              new DropDownOption{ Id = 99, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Montpellier"},
              new DropDownOption{ Id = 100, ParentId = new HashSet<int> { 5 }, DisplayValue =  "FC Nantes"},
              new DropDownOption{ Id = 101, ParentId = new HashSet<int> { 5 }, DisplayValue =  "OGC Nice"},
              new DropDownOption{ Id = 102, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Paris SG"},
              new DropDownOption{ Id = 103, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Rennes"},
              new DropDownOption{ Id = 104, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Strasbourg"},
              new DropDownOption{ Id = 105, ParentId = new HashSet<int> { 5 }, DisplayValue =  "FC Lorient"},
              new DropDownOption{ Id = 106, ParentId = new HashSet<int> { 5 }, DisplayValue =  "OM"},
              new DropDownOption{ Id = 107, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Nîmes Olympique"},
              new DropDownOption{ Id = 108, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Stade Brestois 29"},
              new DropDownOption{ Id = 109, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Stade de Reims"},
              new DropDownOption{ Id = 110, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Angers SCO"},
              new DropDownOption{ Id = 111, ParentId = new HashSet<int> { 5 }, DisplayValue =  "ASSE"},
              new DropDownOption{ Id = 112, ParentId = new HashSet<int> { 5 }, DisplayValue =  "Dijon FCO"},

              new DropDownOption{ Id = 113, ParentId = new HashSet<int> { 6 }, DisplayValue =  "AJ Auxerre"},
              new DropDownOption{ Id = 114, ParentId = new HashSet<int> { 6 }, DisplayValue =  "EA Guingamp"},
              new DropDownOption{ Id = 115, ParentId = new HashSet<int> { 6 }, DisplayValue =  "SM Caen"},
              new DropDownOption{ Id = 116, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Châteauroux"},
              new DropDownOption{ Id = 117, ParentId = new HashSet<int> { 6 }, DisplayValue =  "FCSM"},
              new DropDownOption{ Id = 118, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Troyes"},
              new DropDownOption{ Id = 119, ParentId = new HashSet<int> { 6 }, DisplayValue =  "AC Ajaccio"},
              new DropDownOption{ Id = 120, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Havre AC"},
              new DropDownOption{ Id = 121, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Grenoble"},
              new DropDownOption{ Id = 122, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Toulouse FC"},
              new DropDownOption{ Id = 123, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Niort"},
              new DropDownOption{ Id = 124, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Clermont"},
              new DropDownOption{ Id = 125, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Amiens SC"},
              new DropDownOption{ Id = 126, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Nancy"},
              new DropDownOption{ Id = 127, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Pau FC"},
              new DropDownOption{ Id = 128, ParentId = new HashSet<int> { 6 }, DisplayValue =  "VAFC"},
              new DropDownOption{ Id = 129, ParentId = new HashSet<int> { 6 }, DisplayValue =  "USL Dunkerque"},
              new DropDownOption{ Id = 130, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Rodez AF"},
              new DropDownOption{ Id = 131, ParentId = new HashSet<int> { 6 }, DisplayValue =  "Paris FC"},
              new DropDownOption{ Id = 132, ParentId = new HashSet<int> { 6 }, DisplayValue =  "FC Chambly"},

              new DropDownOption{ Id = 133, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Atalanta"},
              new DropDownOption{ Id = 134, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Inter"},
              new DropDownOption{ Id = 135, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Lazio"},
              new DropDownOption{ Id = 136, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Milan"},
              new DropDownOption{ Id = 137, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Napoli"},
              new DropDownOption{ Id = 138, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Parma"},
              new DropDownOption{ Id = 139, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Torino"},
              new DropDownOption{ Id = 140, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Udinese"},
              new DropDownOption{ Id = 141, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Bologna"},
              new DropDownOption{ Id = 142, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Hellas Verona"},
              new DropDownOption{ Id = 143, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Sampdoria"},
              new DropDownOption{ Id = 144, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Cagliari"},
              new DropDownOption{ Id = 145, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Fiorentina"},
              new DropDownOption{ Id = 146, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Genoa"},
              new DropDownOption{ Id = 147, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Crotone"},
              new DropDownOption{ Id = 148, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Sassuolo"},
              new DropDownOption{ Id = 149, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Benevento"},
              new DropDownOption{ Id = 150, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Spezia"},
              new DropDownOption{ Id = 151, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Piemonte Calcio"},
              new DropDownOption{ Id = 152, ParentId = new HashSet<int> { 7 }, DisplayValue =  "Roma FC"},

              new DropDownOption{ Id = 153, ParentId = new HashSet<int> { 8 }, DisplayValue =  "Brescia"},
              new DropDownOption{ Id = 154, ParentId = new HashSet<int> { 8 }, DisplayValue =  "Chievo Verona"},
              new DropDownOption{ Id = 155, ParentId = new HashSet<int> { 8 }, DisplayValue =  "Lecce"},
              new DropDownOption{ Id = 156, ParentId = new HashSet<int> { 8 }, DisplayValue =  "Empoli"},
              new DropDownOption{ Id = 157, ParentId = new HashSet<int> { 8 }, DisplayValue =  "AC Monza"},
              new DropDownOption{ Id = 158, ParentId = new HashSet<int> { 8 }, DisplayValue =  "SPAL"},

              new DropDownOption{ Id = 159, ParentId = new HashSet<int> { 9 }, DisplayValue =  "FC Bayern"},
              new DropDownOption{ Id = 160, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Dortmund"},
              new DropDownOption{ Id = 161, ParentId = new HashSet<int> { 9 }, DisplayValue =  "M'gladbach"},
              new DropDownOption{ Id = 162, ParentId = new HashSet<int> { 9 }, DisplayValue =  "SC Freiburg"},
              new DropDownOption{ Id = 163, ParentId = new HashSet<int> { 9 }, DisplayValue =  "1. FC Köln"},
              new DropDownOption{ Id = 164, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Leverkusen"},
              new DropDownOption{ Id = 165, ParentId = new HashSet<int> { 9 }, DisplayValue =  "FC Schalke 04"},
              new DropDownOption{ Id = 166, ParentId = new HashSet<int> { 9 }, DisplayValue =  "VfB Stuttgart"},
              new DropDownOption{ Id = 167, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Werder Bremen"},
              new DropDownOption{ Id = 168, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Bielefeld"},
              new DropDownOption{ Id = 169, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Hertha Berlin"},
              new DropDownOption{ Id = 170, ParentId = new HashSet<int> { 9 }, DisplayValue =  "1. FSV Mainz 05"},
              new DropDownOption{ Id = 171, ParentId = new HashSet<int> { 9 }, DisplayValue =  "VfL Wolfsburg"},
              new DropDownOption{ Id = 172, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Frankfurt"},
              new DropDownOption{ Id = 173, ParentId = new HashSet<int> { 9 }, DisplayValue =  "Union Berlin"},
              new DropDownOption{ Id = 174, ParentId = new HashSet<int> { 9 }, DisplayValue =  "TSG Hoffenheim"},
              new DropDownOption{ Id = 175, ParentId = new HashSet<int> { 9 }, DisplayValue =  "FC Augsburg"},
              new DropDownOption{ Id = 176, ParentId = new HashSet<int> { 9 }, DisplayValue =  "RB Leipzig"},

              new DropDownOption{ Id = 177, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Hamburger SV"},
              new DropDownOption{ Id = 178, ParentId = new HashSet<int> { 10 }, DisplayValue =  "VfL Bochum"},
              new DropDownOption{ Id = 179, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Greuther Fürth"},
              new DropDownOption{ Id = 180, ParentId = new HashSet<int> { 10 }, DisplayValue =  "1. FC Nürnberg"},
              new DropDownOption{ Id = 181, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Hannover 96"},
              new DropDownOption{ Id = 182, ParentId = new HashSet<int> { 10 }, DisplayValue =  "VfL Osnabrück"},
              new DropDownOption{ Id = 183, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Erzgebirge Aue"},
              new DropDownOption{ Id = 184, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Jahn Regensburg"},
              new DropDownOption{ Id = 185, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Holstein Kiel"},
              new DropDownOption{ Id = 186, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Karlsruher SC"},
              new DropDownOption{ Id = 187, ParentId = new HashSet<int> { 10 }, DisplayValue =  "SC Paderborn 07"},
              new DropDownOption{ Id = 188, ParentId = new HashSet<int> { 10 }, DisplayValue =  "SV Sandhausen"},
              new DropDownOption{ Id = 189, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Würzburg"},
              new DropDownOption{ Id = 190, ParentId = new HashSet<int> { 10 }, DisplayValue =  "FC St. Pauli"},
              new DropDownOption{ Id = 191, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Braunschweig"},
              new DropDownOption{ Id = 192, ParentId = new HashSet<int> { 10 }, DisplayValue =  "SV Darmstadt 98"},
              new DropDownOption{ Id = 193, ParentId = new HashSet<int> { 10 }, DisplayValue =  "Düsseldorf"},
              new DropDownOption{ Id = 194, ParentId = new HashSet<int> { 10 }, DisplayValue =  "1. FC Heidenheim"},

              new DropDownOption{ Id = 195, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Hansa Rostock"},
              new DropDownOption{ Id = 196, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Kaiserslautern"},
              new DropDownOption{ Id = 197, ParentId = new HashSet<int> { 11 }, DisplayValue =  "1860 München"},
              new DropDownOption{ Id = 198, ParentId = new HashSet<int> { 11 }, DisplayValue =  "KFC Uerdingen"},
              new DropDownOption{ Id = 199, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Haching"},
              new DropDownOption{ Id = 200, ParentId = new HashSet<int> { 11 }, DisplayValue =  "SVWW"},
              new DropDownOption{ Id = 201, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Dynamo Dresden"},
              new DropDownOption{ Id = 202, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Saarbrücken"},
              new DropDownOption{ Id = 203, ParentId = new HashSet<int> { 11 }, DisplayValue =  "MSV Duisburg"},
              new DropDownOption{ Id = 204, ParentId = new HashSet<int> { 11 }, DisplayValue =  "VfB Lübeck"},
              new DropDownOption{ Id = 205, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Hallescher FC"},
              new DropDownOption{ Id = 206, ParentId = new HashSet<int> { 11 }, DisplayValue =  "SC Verl"},
              new DropDownOption{ Id = 207, ParentId = new HashSet<int> { 11 }, DisplayValue =  "SV Waldhof"},
              new DropDownOption{ Id = 208, ParentId = new HashSet<int> { 11 }, DisplayValue =  "1. FC Magdeburg"},
              new DropDownOption{ Id = 209, ParentId = new HashSet<int> { 11 }, DisplayValue =  "FSV Zwickau"},
              new DropDownOption{ Id = 210, ParentId = new HashSet<int> { 11 }, DisplayValue =  "SV Meppen"},
              new DropDownOption{ Id = 211, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Viktoria Köln"},
              new DropDownOption{ Id = 212, ParentId = new HashSet<int> { 11 }, DisplayValue =  "FC Bayern II"},
              new DropDownOption{ Id = 213, ParentId = new HashSet<int> { 11 }, DisplayValue =  "FC Ingolstadt"},
              new DropDownOption{ Id = 214, ParentId = new HashSet<int> { 11 }, DisplayValue =  "Türkgücü"},

              new DropDownOption{ Id = 215, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Atlético de Madrid"},
              new DropDownOption{ Id = 216, ParentId = new HashSet<int> { 12 }, DisplayValue =  "FC Barcelona"},
              new DropDownOption{ Id = 217, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Real Madrid"},
              new DropDownOption{ Id = 218, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Real Betis"},
              new DropDownOption{ Id = 219, ParentId = new HashSet<int> { 12 }, DisplayValue =  "RC Celta"},
              new DropDownOption{ Id = 220, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Real Sociedad"},
              new DropDownOption{ Id = 221, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Valencia CF"},
              new DropDownOption{ Id = 222, ParentId = new HashSet<int> { 12 }, DisplayValue =  "R. Valladolid CF"},
              new DropDownOption{ Id = 223, ParentId = new HashSet<int> { 12 }, DisplayValue =  "D. Alavés"},
              new DropDownOption{ Id = 224, ParentId = new HashSet<int> { 12 }, DisplayValue =  "SD Eibar"},
              new DropDownOption{ Id = 225, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Elche CF"},
              new DropDownOption{ Id = 226, ParentId = new HashSet<int> { 12 }, DisplayValue =  "CA Osasuna"},
              new DropDownOption{ Id = 227, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Sevilla FC"},
              new DropDownOption{ Id = 228, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Villarreal CF"},
              new DropDownOption{ Id = 229, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Levante UD"},
              new DropDownOption{ Id = 230, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Getafe CF"},
              new DropDownOption{ Id = 231, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Cádiz CF"},
              new DropDownOption{ Id = 232, ParentId = new HashSet<int> { 12 }, DisplayValue =  "Granada CF"},
              new DropDownOption{ Id = 233, ParentId = new HashSet<int> { 12 }, DisplayValue =  "SD Huesca"},                
            };
        }         
    }
}
