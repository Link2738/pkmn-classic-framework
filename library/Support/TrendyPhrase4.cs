﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PkmnFoundations.Support
{
    public class TrendyPhrase4
    {
        #region String tables
        // Special thanks to http://projectpokemon.org/rawdb/diamond/msg.php
        // for their string table dumps.

        // msg.narc/395 through /399
        private static String[,] PHRASES = new String[,]
        {
            {
                "Please!\n{0}!",
                "Go! {0}!",
                "I’ll battle with\n{0}!",
                "It’s {0}!",
                "{0}, I’m going\nwith {1}!",
                "Look at {0}!",
                "I’ll show you {0}!",
                "Now!\n{0}!",
                "I’ll show you my\n{0} strategy!",
                "I’ll {0}!",
                "I’ll shock you with\n{0}!",
                "This is the beginning\nof {0}!",
                "This battle is\n{0}!",
                "I don’t think I’ll\never lose at {0}!",
                "Team {0} is here!",
                "You think you can beat\n{0}?",
                "{0}!\n{1} power!",
                "This is the {0}\nPokémon!",
                "{0} won’t lose!",
                "Please {0}!\n{1}!"
            },
            {
                "I win!\n{0}!",
                "I won!\nI won with {0}!",
                "{0} is strong,\nisn’t it?",
                "It’s {0}\n{1} after all!",
                "{0}, yay!",
                "Yay, {0}!\n{1}!",
                "Sorry, it’s {0}\n{1}.",
                "{0}!\nThank you!",
                "The way I feel now is\n{0}!",
                "I wanted people to look at\nmy {0}!",
                "It’s all thanks to\n{0}.",
                "I might have won with\n{0}!",
                "I get the happiest with\n{0}!",
                "{0} secured\nthe victory!",
                "This {0}\nwas really good!",
                "{0}\nwas fun, wasn’t it?",
                "Huh?\n{0}?!",
                "{0} is the toughest!",
                "Happy!\n{0} happy!",
                "How’s that?!\n{0}!"
            },
            {
                "You win...\n{0}",
                "{0} was the one\nthing I wanted to avoid...",
                "Waaah!\n{0}!",
                "I want to go home with\n{0}...",
                "{0}!\n{1}!",
                "Could it be...?\n{0}...?",
                "{0}!\nHow awful!",
                "I was confident about\n{0}, too.",
                "You're {0},\naren’t you?",
                "{0}!\nCan’t be anything else but.",
                "I feel so helplessly angry...\nIt’s {0}!",
                "{0} makes me sad...",
                "I feel sorry for\n{0}!",
                "The way I feel now is\n{0}...",
                "I lost, but I won at\n{0}!",
                "I would’ve won if this\nwere {0}...",
                "My head’s filled with only\n{0} now!",
                "The way I lost...\nIt’s like {0}...",
                "Isn’t {0}\n{1}?",
                "Aww... That’s really\n{0}..."
            },
            {
                "Hello!\n{0}!",
                "I love {0}!",
                "I love {0}!\nI love {1}, too!",
                "This {0} is\n{1}, isn’t it?",
                "I can do anything for\n{0}!",
                "This {0} is\n{1}!",
                "{0} is the real\n{1}!",
                "It might be {0}...",
                "There’s only {0}\nleft!",
                "It’s {0}!\nIt’s {1}!",
                "I prefer {0}\nafter all!",
                "Is {0}\n{1}?",
                "Do you like {0}?",
                "What do you think of\n{0}?",
                "{0} is so\n{1}!",
                "{0} are\n{1}!",
                "{0}, right?",
                "Did you know {0}?\nIt’s {1}!",
                "Excuse me...\nIt’s {0}!",
                "{0}, right?\n{1}!"
            },
            {
                "{0}!\nHello!",
                "Glad to meet you!\nI love {0}!",
                "I’m a {0} Trainer!\nPlease battle me!",
                "Please trade!\nI’m offering {0}!",
                "Please trade!\nI want a {0}!",
                "I’ve entered the Union Room.",
                "Let’s draw! I want to draw\n{0}!",
                "I’ve got to go!\n{0}!",
                "Please leave me alone...",
                "Anyone want to\n{0}?",
                "Let’s {0}!",
                "Want to {0}?",
                "I want to {0}!",
                "OK!",
                "I don’t want to\n{0}.",
                "I’ll go wait at the Colosseum\nnow.",
                "Please talk to me!",
                "Do you know where I am?",
                "I want to trade my {0}.\nPlease talk to me.",
                "I want a {0} battle!\nPlease talk to me!"
            }
        };

        // 0-495: msg.narc/362 Pokemon
        // 496-963: msg.narc/589 Attacks
        // 964-981: msg.narc/565 Types
        // 982-1105: msg.narc/553 Abilities
        // 1106-1143: msg.narc/388 "Trainer"
        // 1144-1181: msg.narc/389 "People"
        // 1182-1288: msg.narc/390 "Greetings"
        // 1289-1392: msg.narc/391 "Lifestyle"
        // 1393-1439: msg.narc/392 "Feelings"
        // 1440-1471: msg.narc/393 "Tough words"
        // 1472-1494: msg.narc/394 "Union"
        private static String[] WORDS_POKEMON = new String[]
        {
            "-----","BULBASAUR","IVYSAUR","VENUSAUR",
            "CHARMANDER","CHARMELEON","CHARIZARD","SQUIRTLE",
            "WARTORTLE","BLASTOISE","CATERPIE","METAPOD",
            "BUTTERFREE","WEEDLE","KAKUNA","BEEDRILL",
            "PIDGEY","PIDGEOTTO","PIDGEOT","RATTATA",
            "RATICATE","SPEAROW","FEAROW","EKANS",
            "ARBOK","PIKACHU","RAICHU","SANDSHREW",
            "SANDSLASH","NIDORAN♀","NIDORINA","NIDOQUEEN",
            "NIDORAN♂","NIDORINO","NIDOKING","CLEFAIRY",
            "CLEFABLE","VULPIX","NINETALES","JIGGLYPUFF",
            "WIGGLYTUFF","ZUBAT","GOLBAT","ODDISH",
            "GLOOM","VILEPLUME","PARAS","PARASECT",
            "VENONAT","VENOMOTH","DIGLETT","DUGTRIO",
            "MEOWTH","PERSIAN","PSYDUCK","GOLDUCK",
            "MANKEY","PRIMEAPE","GROWLITHE","ARCANINE",
            "POLIWAG","POLIWHIRL","POLIWRATH","ABRA",
            "KADABRA","ALAKAZAM","MACHOP","MACHOKE",
            "MACHAMP","BELLSPROUT","WEEPINBELL","VICTREEBEL",
            "TENTACOOL","TENTACRUEL","GEODUDE","GRAVELER",
            "GOLEM","PONYTA","RAPIDASH","SLOWPOKE",
            "SLOWBRO","MAGNEMITE","MAGNETON","FARFETCH’D",
            "DODUO","DODRIO","SEEL","DEWGONG",
            "GRIMER","MUK","SHELLDER","CLOYSTER",
            "GASTLY","HAUNTER","GENGAR","ONIX",
            "DROWZEE","HYPNO","KRABBY","KINGLER",
            "VOLTORB","ELECTRODE","EXEGGCUTE","EXEGGUTOR",
            "CUBONE","MAROWAK","HITMONLEE","HITMONCHAN",
            "LICKITUNG","KOFFING","WEEZING","RHYHORN",
            "RHYDON","CHANSEY","TANGELA","KANGASKHAN",
            "HORSEA","SEADRA","GOLDEEN","SEAKING",
            "STARYU","STARMIE","MR. MIME","SCYTHER",
            "JYNX","ELECTABUZZ","MAGMAR","PINSIR",
            "TAUROS","MAGIKARP","GYARADOS","LAPRAS",
            "DITTO","EEVEE","VAPOREON","JOLTEON",
            "FLAREON","PORYGON","OMANYTE","OMASTAR",
            "KABUTO","KABUTOPS","AERODACTYL","SNORLAX",
            "ARTICUNO","ZAPDOS","MOLTRES","DRATINI",
            "DRAGONAIR","DRAGONITE","MEWTWO","MEW",
            "CHIKORITA","BAYLEEF","MEGANIUM","CYNDAQUIL",
            "QUILAVA","TYPHLOSION","TOTODILE","CROCONAW",
            "FERALIGATR","SENTRET","FURRET","HOOTHOOT",
            "NOCTOWL","LEDYBA","LEDIAN","SPINARAK",
            "ARIADOS","CROBAT","CHINCHOU","LANTURN",
            "PICHU","CLEFFA","IGGLYBUFF","TOGEPI",
            "TOGETIC","NATU","XATU","MAREEP",
            "FLAAFFY","AMPHAROS","BELLOSSOM","MARILL",
            "AZUMARILL","SUDOWOODO","POLITOED","HOPPIP",
            "SKIPLOOM","JUMPLUFF","AIPOM","SUNKERN",
            "SUNFLORA","YANMA","WOOPER","QUAGSIRE",
            "ESPEON","UMBREON","MURKROW","SLOWKING",
            "MISDREAVUS","UNOWN","WOBBUFFET","GIRAFARIG",
            "PINECO","FORRETRESS","DUNSPARCE","GLIGAR",
            "STEELIX","SNUBBULL","GRANBULL","QWILFISH",
            "SCIZOR","SHUCKLE","HERACROSS","SNEASEL",
            "TEDDIURSA","URSARING","SLUGMA","MAGCARGO",
            "SWINUB","PILOSWINE","CORSOLA","REMORAID",
            "OCTILLERY","DELIBIRD","MANTINE","SKARMORY",
            "HOUNDOUR","HOUNDOOM","KINGDRA","PHANPY",
            "DONPHAN","PORYGON2","STANTLER","SMEARGLE",
            "TYROGUE","HITMONTOP","SMOOCHUM","ELEKID",
            "MAGBY","MILTANK","BLISSEY","RAIKOU",
            "ENTEI","SUICUNE","LARVITAR","PUPITAR",
            "TYRANITAR","LUGIA","HO-OH","CELEBI",
            "TREECKO","GROVYLE","SCEPTILE","TORCHIC",
            "COMBUSKEN","BLAZIKEN","MUDKIP","MARSHTOMP",
            "SWAMPERT","POOCHYENA","MIGHTYENA","ZIGZAGOON",
            "LINOONE","WURMPLE","SILCOON","BEAUTIFLY",
            "CASCOON","DUSTOX","LOTAD","LOMBRE",
            "LUDICOLO","SEEDOT","NUZLEAF","SHIFTRY",
            "TAILLOW","SWELLOW","WINGULL","PELIPPER",
            "RALTS","KIRLIA","GARDEVOIR","SURSKIT",
            "MASQUERAIN","SHROOMISH","BRELOOM","SLAKOTH",
            "VIGOROTH","SLAKING","NINCADA","NINJASK",
            "SHEDINJA","WHISMUR","LOUDRED","EXPLOUD",
            "MAKUHITA","HARIYAMA","AZURILL","NOSEPASS",
            "SKITTY","DELCATTY","SABLEYE","MAWILE",
            "ARON","LAIRON","AGGRON","MEDITITE",
            "MEDICHAM","ELECTRIKE","MANECTRIC","PLUSLE",
            "MINUN","VOLBEAT","ILLUMISE","ROSELIA",
            "GULPIN","SWALOT","CARVANHA","SHARPEDO",
            "WAILMER","WAILORD","NUMEL","CAMERUPT",
            "TORKOAL","SPOINK","GRUMPIG","SPINDA",
            "TRAPINCH","VIBRAVA","FLYGON","CACNEA",
            "CACTURNE","SWABLU","ALTARIA","ZANGOOSE",
            "SEVIPER","LUNATONE","SOLROCK","BARBOACH",
            "WHISCASH","CORPHISH","CRAWDAUNT","BALTOY",
            "CLAYDOL","LILEEP","CRADILY","ANORITH",
            "ARMALDO","FEEBAS","MILOTIC","CASTFORM",
            "KECLEON","SHUPPET","BANETTE","DUSKULL",
            "DUSCLOPS","TROPIUS","CHIMECHO","ABSOL",
            "WYNAUT","SNORUNT","GLALIE","SPHEAL",
            "SEALEO","WALREIN","CLAMPERL","HUNTAIL",
            "GOREBYSS","RELICANTH","LUVDISC","BAGON",
            "SHELGON","SALAMENCE","BELDUM","METANG",
            "METAGROSS","REGIROCK","REGICE","REGISTEEL",
            "LATIAS","LATIOS","KYOGRE","GROUDON",
            "RAYQUAZA","JIRACHI","DEOXYS","TURTWIG",
            "GROTLE","TORTERRA","CHIMCHAR","MONFERNO",
            "INFERNAPE","PIPLUP","PRINPLUP","EMPOLEON",
            "STARLY","STARAVIA","STARAPTOR","BIDOOF",
            "BIBAREL","KRICKETOT","KRICKETUNE","SHINX",
            "LUXIO","LUXRAY","BUDEW","ROSERADE",
            "CRANIDOS","RAMPARDOS","SHIELDON","BASTIODON",
            "BURMY","WORMADAM","MOTHIM","COMBEE",
            "VESPIQUEN","PACHIRISU","BUIZEL","FLOATZEL",
            "CHERUBI","CHERRIM","SHELLOS","GASTRODON",
            "AMBIPOM","DRIFLOON","DRIFBLIM","BUNEARY",
            "LOPUNNY","MISMAGIUS","HONCHKROW","GLAMEOW",
            "PURUGLY","CHINGLING","STUNKY","SKUNTANK",
            "BRONZOR","BRONZONG","BONSLY","MIME JR.",
            "HAPPINY","CHATOT","SPIRITOMB","GIBLE",
            "GABITE","GARCHOMP","MUNCHLAX","RIOLU",
            "LUCARIO","HIPPOPOTAS","HIPPOWDON","SKORUPI",
            "DRAPION","CROAGUNK","TOXICROAK","CARNIVINE",
            "FINNEON","LUMINEON","MANTYKE","SNOVER",
            "ABOMASNOW","WEAVILE","MAGNEZONE","LICKILICKY",
            "RHYPERIOR","TANGROWTH","ELECTIVIRE","MAGMORTAR",
            "TOGEKISS","YANMEGA","LEAFEON","GLACEON",
            "GLISCOR","MAMOSWINE","PORYGON-Z","GALLADE",
            "PROBOPASS","DUSKNOIR","FROSLASS","ROTOM",
            "UXIE","MESPRIT","AZELF","DIALGA",
            "PALKIA","HEATRAN","REGIGIGAS","GIRATINA",
            "CRESSELIA","PHIONE","MANAPHY","DARKRAI",
            "SHAYMIN","ARCEUS","Egg","Bad Egg"
        };

        private static String[] WORDS_MOVES = new String[]
        {
            "-","POUND","KARATE CHOP","DOUBLESLAP",
            "COMET PUNCH","MEGA PUNCH","PAY DAY","FIRE PUNCH",
            "ICE PUNCH","THUNDERPUNCH","SCRATCH","VICEGRIP",
            "GUILLOTINE","RAZOR WIND","SWORDS DANCE","CUT",
            "GUST","WING ATTACK","WHIRLWIND","FLY",
            "BIND","SLAM","VINE WHIP","STOMP",
            "DOUBLE KICK","MEGA KICK","JUMP KICK","ROLLING KICK",
            "SAND-ATTACK","HEADBUTT","HORN ATTACK","FURY ATTACK",
            "HORN DRILL","TACKLE","BODY SLAM","WRAP",
            "TAKE DOWN","THRASH","DOUBLE-EDGE","TAIL WHIP",
            "POISON STING","TWINEEDLE","PIN MISSILE","LEER",
            "BITE","GROWL","ROAR","SING",
            "SUPERSONIC","SONICBOOM","DISABLE","ACID",
            "EMBER","FLAMETHROWER","MIST","WATER GUN",
            "HYDRO PUMP","SURF","ICE BEAM","BLIZZARD",
            "PSYBEAM","BUBBLEBEAM","AURORA BEAM","HYPER BEAM",
            "PECK","DRILL PECK","SUBMISSION","LOW KICK",
            "COUNTER","SEISMIC TOSS","STRENGTH","ABSORB",
            "MEGA DRAIN","LEECH SEED","GROWTH","RAZOR LEAF",
            "SOLARBEAM","POISONPOWDER","STUN SPORE","SLEEP POWDER",
            "PETAL DANCE","STRING SHOT","DRAGON RAGE","FIRE SPIN",
            "THUNDERSHOCK","THUNDERBOLT","THUNDER WAVE","THUNDER",
            "ROCK THROW","EARTHQUAKE","FISSURE","DIG",
            "TOXIC","CONFUSION","PSYCHIC","HYPNOSIS",
            "MEDITATE","AGILITY","QUICK ATTACK","RAGE",
            "TELEPORT","NIGHT SHADE","MIMIC","SCREECH",
            "DOUBLE TEAM","RECOVER","HARDEN","MINIMIZE",
            "SMOKESCREEN","CONFUSE RAY","WITHDRAW","DEFENSE CURL",
            "BARRIER","LIGHT SCREEN","HAZE","REFLECT",
            "FOCUS ENERGY","BIDE","METRONOME","MIRROR MOVE",
            "SELFDESTRUCT","EGG BOMB","LICK","SMOG",
            "SLUDGE","BONE CLUB","FIRE BLAST","WATERFALL",
            "CLAMP","SWIFT","SKULL BASH","SPIKE CANNON",
            "CONSTRICT","AMNESIA","KINESIS","SOFTBOILED",
            "HI JUMP KICK","GLARE","DREAM EATER","POISON GAS",
            "BARRAGE","LEECH LIFE","LOVELY KISS","SKY ATTACK",
            "TRANSFORM","BUBBLE","DIZZY PUNCH","SPORE",
            "FLASH","PSYWAVE","SPLASH","ACID ARMOR",
            "CRABHAMMER","EXPLOSION","FURY SWIPES","BONEMERANG",
            "REST","ROCK SLIDE","HYPER FANG","SHARPEN",
            "CONVERSION","TRI ATTACK","SUPER FANG","SLASH",
            "SUBSTITUTE","STRUGGLE","SKETCH","TRIPLE KICK",
            "THIEF","SPIDER WEB","MIND READER","NIGHTMARE",
            "FLAME WHEEL","SNORE","CURSE","FLAIL",
            "CONVERSION 2","AEROBLAST","COTTON SPORE","REVERSAL",
            "SPITE","POWDER SNOW","PROTECT","MACH PUNCH",
            "SCARY FACE","FAINT ATTACK","SWEET KISS","BELLY DRUM",
            "SLUDGE BOMB","MUD-SLAP","OCTAZOOKA","SPIKES",
            "ZAP CANNON","FORESIGHT","DESTINY BOND","PERISH SONG",
            "ICY WIND","DETECT","BONE RUSH","LOCK-ON",
            "OUTRAGE","SANDSTORM","GIGA DRAIN","ENDURE",
            "CHARM","ROLLOUT","FALSE SWIPE","SWAGGER",
            "MILK DRINK","SPARK","FURY CUTTER","STEEL WING",
            "MEAN LOOK","ATTRACT","SLEEP TALK","HEAL BELL",
            "RETURN","PRESENT","FRUSTRATION","SAFEGUARD",
            "PAIN SPLIT","SACRED FIRE","MAGNITUDE","DYNAMICPUNCH",
            "MEGAHORN","DRAGONBREATH","BATON PASS","ENCORE",
            "PURSUIT","RAPID SPIN","SWEET SCENT","IRON TAIL",
            "METAL CLAW","VITAL THROW","MORNING SUN","SYNTHESIS",
            "MOONLIGHT","HIDDEN POWER","CROSS CHOP","TWISTER",
            "RAIN DANCE","SUNNY DAY","CRUNCH","MIRROR COAT",
            "PSYCH UP","EXTREMESPEED","ANCIENTPOWER","SHADOW BALL",
            "FUTURE SIGHT","ROCK SMASH","WHIRLPOOL","BEAT UP",
            "FAKE OUT","UPROAR","STOCKPILE","SPIT UP",
            "SWALLOW","HEAT WAVE","HAIL","TORMENT",
            "FLATTER","WILL-O-WISP","MEMENTO","FACADE",
            "FOCUS PUNCH","SMELLINGSALT","FOLLOW ME","NATURE POWER",
            "CHARGE","TAUNT","HELPING HAND","TRICK",
            "ROLE PLAY","WISH","ASSIST","INGRAIN",
            "SUPERPOWER","MAGIC COAT","RECYCLE","REVENGE",
            "BRICK BREAK","YAWN","KNOCK OFF","ENDEAVOR",
            "ERUPTION","SKILL SWAP","IMPRISON","REFRESH",
            "GRUDGE","SNATCH","SECRET POWER","DIVE",
            "ARM THRUST","CAMOUFLAGE","TAIL GLOW","LUSTER PURGE",
            "MIST BALL","FEATHERDANCE","TEETER DANCE","BLAZE KICK",
            "MUD SPORT","ICE BALL","NEEDLE ARM","SLACK OFF",
            "HYPER VOICE","POISON FANG","CRUSH CLAW","BLAST BURN",
            "HYDRO CANNON","METEOR MASH","ASTONISH","WEATHER BALL",
            "AROMATHERAPY","FAKE TEARS","AIR CUTTER","OVERHEAT",
            "ODOR SLEUTH","ROCK TOMB","SILVER WIND","METAL SOUND",
            "GRASSWHISTLE","TICKLE","COSMIC POWER","WATER SPOUT",
            "SIGNAL BEAM","SHADOW PUNCH","EXTRASENSORY","SKY UPPERCUT",
            "SAND TOMB","SHEER COLD","MUDDY WATER","BULLET SEED",
            "AERIAL ACE","ICICLE SPEAR","IRON DEFENSE","BLOCK",
            "HOWL","DRAGON CLAW","FRENZY PLANT","BULK UP",
            "BOUNCE","MUD SHOT","POISON TAIL","COVET",
            "VOLT TACKLE","MAGICAL LEAF","WATER SPORT","CALM MIND",
            "LEAF BLADE","DRAGON DANCE","ROCK BLAST","SHOCK WAVE",
            "WATER PULSE","DOOM DESIRE","PSYCHO BOOST","ROOST",
            "GRAVITY","MIRACLE EYE","WAKE-UP SLAP","HAMMER ARM",
            "GYRO BALL","HEALING WISH","BRINE","NATURAL GIFT",
            "FEINT","PLUCK","TAILWIND","ACUPRESSURE",
            "METAL BURST","U-TURN","CLOSE COMBAT","PAYBACK",
            "ASSURANCE","EMBARGO","FLING","PSYCHO SHIFT",
            "TRUMP CARD","HEAL BLOCK","WRING OUT","POWER TRICK",
            "GASTRO ACID","LUCKY CHANT","ME FIRST","COPYCAT",
            "POWER SWAP","GUARD SWAP","PUNISHMENT","LAST RESORT",
            "WORRY SEED","SUCKER PUNCH","TOXIC SPIKES","HEART SWAP",
            "AQUA RING","MAGNET RISE","FLARE BLITZ","FORCE PALM",
            "AURA SPHERE","ROCK POLISH","POISON JAB","DARK PULSE",
            "NIGHT SLASH","AQUA TAIL","SEED BOMB","AIR SLASH",
            "X-SCISSOR","BUG BUZZ","DRAGON PULSE","DRAGON RUSH",
            "POWER GEM","DRAIN PUNCH","VACUUM WAVE","FOCUS BLAST",
            "ENERGY BALL","BRAVE BIRD","EARTH POWER","SWITCHEROO",
            "GIGA IMPACT","NASTY PLOT","BULLET PUNCH","AVALANCHE",
            "ICE SHARD","SHADOW CLAW","THUNDER FANG","ICE FANG",
            "FIRE FANG","SHADOW SNEAK","MUD BOMB","PSYCHO CUT",
            "ZEN HEADBUTT","MIRROR SHOT","FLASH CANNON","ROCK CLIMB",
            "DEFOG","TRICK ROOM","DRACO METEOR","DISCHARGE",
            "LAVA PLUME","LEAF STORM","POWER WHIP","ROCK WRECKER",
            "CROSS POISON","GUNK SHOT","IRON HEAD","MAGNET BOMB",
            "STONE EDGE","CAPTIVATE","STEALTH ROCK","GRASS KNOT",
            "CHATTER","JUDGMENT","BUG BITE","CHARGE BEAM",
            "WOOD HAMMER","AQUA JET","ATTACK ORDER","DEFEND ORDER",
            "HEAL ORDER","HEAD SMASH","DOUBLE HIT","ROAR OF TIME",
            "SPACIAL REND","LUNAR DANCE","CRUSH GRIP","MAGMA STORM",
            "DARK VOID","SEED FLARE","OMINOUS WIND","SHADOW FORCE"
        };

        private static String[] WORDS_TYPES = new String[]
        {
            "NORMAL","FIGHTING","FLYING","POISON",
            "GROUND","ROCK","BUG","GHOST",
            "STEEL","???","FIRE","WATER",
            "GRASS","ELECTRIC","PSYCHIC","ICE",
            "DRAGON","DARK"
        };

        private static String[] WORDS_ABILITIES = new String[]
        {
            "-","STENCH","DRIZZLE","SPEED BOOST",
            "BATTLE ARMOR","STURDY","DAMP","LIMBER",
            "SAND VEIL","STATIC","VOLT ABSORB","WATER ABSORB",
            "OBLIVIOUS","CLOUD NINE","COMPOUNDEYES","INSOMNIA",
            "COLOR CHANGE","IMMUNITY","FLASH FIRE","SHIELD DUST",
            "OWN TEMPO","SUCTION CUPS","INTIMIDATE","SHADOW TAG",
            "ROUGH SKIN","WONDER GUARD","LEVITATE","EFFECT SPORE",
            "SYNCHRONIZE","CLEAR BODY","NATURAL CURE","LIGHTNINGROD",
            "SERENE GRACE","SWIFT SWIM","CHLOROPHYLL","ILLUMINATE",
            "TRACE","HUGE POWER","POISON POINT","INNER FOCUS",
            "MAGMA ARMOR","WATER VEIL","MAGNET PULL","SOUNDPROOF",
            "RAIN DISH","SAND STREAM","PRESSURE","THICK FAT",
            "EARLY BIRD","FLAME BODY","RUN AWAY","KEEN EYE",
            "HYPER CUTTER","PICKUP","TRUANT","HUSTLE",
            "CUTE CHARM","PLUS","MINUS","FORECAST",
            "STICKY HOLD","SHED SKIN","GUTS","MARVEL SCALE",
            "LIQUID OOZE","OVERGROW","BLAZE","TORRENT",
            "SWARM","ROCK HEAD","DROUGHT","ARENA TRAP",
            "VITAL SPIRIT","WHITE SMOKE","PURE POWER","SHELL ARMOR",
            "AIR LOCK","TANGLED FEET","MOTOR DRIVE","RIVALRY",
            "STEADFAST","SNOW CLOAK","GLUTTONY","ANGER POINT",
            "UNBURDEN","HEATPROOF","SIMPLE","DRY SKIN",
            "DOWNLOAD","IRON FIST","POISON HEAL","ADAPTABILITY",
            "SKILL LINK","HYDRATION","SOLAR POWER","QUICK FEET",
            "NORMALIZE","SNIPER","MAGIC GUARD","NO GUARD",
            "STALL","TECHNICIAN","LEAF GUARD","KLUTZ",
            "MOLD BREAKER","SUPER LUCK","AFTERMATH","ANTICIPATION",
            "FOREWARN","UNAWARE","TINTED LENS","FILTER",
            "SLOW START","SCRAPPY","STORM DRAIN","ICE BODY",
            "SOLID ROCK","SNOW WARNING","HONEY GATHER","FRISK",
            "RECKLESS","MULTITYPE","FLOWER GIFT","BAD DREAMS"
        };

        private static String[] WORDS_TRAINER = new String[]
        {
            "MATCH UP","NO. 1","PREPARATION","WINS",
            "NO MATCH","SPIRIT","ACE CARD","COME ON",
            "ATTACK","SURRENDER","COURAGE","TALENT",
            "STRATEGY","MATCH","VICTORY","SENSE",
            "VERSUS","FIGHTS","POWER","CHALLENGE",
            "STRONG","TAKE IT EASY","FOE","GENIUS",
            "LEGEND","BATTLE","FIGHT","REVIVE",
            "POINTS","SERIOUS","LOSS","PARTNER",
            "INVINCIBLE","EASY","WEAK","EASY WIN",
            "MOVE","TRAINER"
        };

        private static String[] WORDS_PEOPLE = new String[]
        {
            "OPPONENT","I","YOU","MOTHER",
            "GRANDFATHER","UNCLE","FATHER","BOY",
            "ADULT","BROTHER","SISTER","GRANDMOTHER",
            "AUNT","PARENT","OLD MAN","ME",
            "GIRL","GAL","FAMILY","HER",
            "HIM","YOU","SIBLINGS","KIDS",
            "MR.","MS.","MYSELF","WHO",
            "FRIEND","ALLY","PERSON","KIDS",
            "I","EVERYONE","RIVAL","I",
            "I","BABY"
        };

        private static String[] WORDS_GREETINGS = new String[]
        {
            "KONNICHIWA","HELLO","BONJOUR","CIAO",
            "HALLO","HOLA","OH WELL","AAH",
            "AHAHA","HUH","THANKS","NO PROBLEM",
            "NOPE","YES","HERE GOES","LET’S GO",
            "HERE I COME","YEAH","WELCOME","URGH",
            "LET ME THINK","HMM","WHOA","WROOOAAR!",
            "WOW","SNICKER","CUTE LAUGH","UNBELIEVABLE",
            "CRIES","OK","AGREE","EH?",
            "BOO-HOO","HEHEHE","HEY","OH, YEAH",
            "OH WOW!","HEEEY","GREETINGS","OOPS",
            "WELL DONE","OH MY","EEK","YAAAH",
            "GIGGLE","GIVE ME","GWAHAHAHA","UGH",
            "SORRY","FORGIVE ME","I’M SORRY","HEY!",
            "GOOD-BYE","THANK YOU","I’VE ARRIVED","WEEP",
            "PARDON ME","SO SORRY","SEE YA","EXCUSE ME",
            "OKAY THEN","TUT","BLUSH","GO AHEAD",
            "CHEERS","HEY?","WHAT’S UP?","HUH?",
            "NO","SIGH","HI","YEP",
            "YEAH, YEAH","BYE-BYE","MEET YOU","HAHAHA",
            "AIYEEH","HIYAH","MUHAHAHA","LOL",
            "SNORT","HUMPH","HEY","HE-HE-HE",
            "HEH","HOHOHO","THERE YOU GO","OH, DEAR",
            "BYE FOR NOW","ANGRY","MUFUFU","MMM",
            "HELLO?","HI THERE","NO WAY","YAHOO",
            "YO","WELCOME","OK","REGARDS",
            "LALALA","YAY","WAIL","WOW",
            "BOO!","WAHAHA","..."
        };

        private static String[] WORDS_LIFESTYLE = new String[]
        {
            "IDOL","TOMORROW","PLAYING","ANIME",
            "JOB","SONG","HOME","MOVIE",
            "SWEETS","MONEY","POCKET MONEY","CHIT-CHAT",
            "TALK","BATH","PLAY HOUSE","TOYS",
            "MUSIC","CARDS","SHOPPING","CONVERSATION",
            "SCHOOL","CAMERA","VIEWING","SPECTATE",
            "ANNIVERSARY","YESTERDAY","TODAY","HABIT",
            "GROUP","GOURMET","GAME","WORD",
            "COLLECTION","STORE","COMPLETE","SERVICE",
            "MAGAZINE","WALK","WORK","SYSTEM",
            "BICYCLE","TRAINING","CLASS","LESSONS",
            "HOBBY","INFORMATION","SPORTS","DAILY LIFE",
            "TEACHER","SOFTWARE","SONGS","DIET",
            "TOURNAMENT","TREASURE","TRAVEL","BIRTHDAY",
            "DANCE","CHANNEL","FISHING","DATE",
            "LETTER","EVENT","DESIGN","DIGITAL",
            "TEST","DEPT. STORE","TELEVISION","TRAIN",
            "PHONE","ITEM","NAME","NEWS",
            "POPULARITY","STUFFED TOY","PARTY","COMPUTER",
            "FLOWERS","HERO","NAP","HEROINE",
            "FASHION","STUDY","ADVENTURE","BOARD",
            "BALL","BOOK","MACHINE","FESTIVAL",
            "COMICS","MAIL","MESSAGE","STORY",
            "PROMISE","HOLIDAY","DREAM","KINDERGARTEN",
            "PLANS","LIFE","RADIO","CRAZE",
            "VACATION","LOOKS","RENTAL","WORLD"
        };

        private static String[] WORDS_FEELINGS = new String[]
        {
            "BEAUTY","DELIGHT","STRANGENESS","CLEVERNESS",
            "DISAPPOINTED","COOLNESS","SADNESS","CUTENESS",
            "ANGER","HEALTHY","REGRET","HAPPINESS",
            "DEPRESSED","INCREDIBLE","LIKES","DISLIKE",
            "BORED","IMPORTANT","ALL RIGHT","ADORE",
            "TOUGHNESS","ENJOYMENT","USELESS","DROOLING",
            "EXCITED","SKILLFUL","TEARS","HATE",
            "ROFL","HAPPY","ENERGETIC","SURPRISE",
            "NERVOUS","WANT","SATISFIED","RARE",
            "MESSED UP","NO WAY","DANGER","LOVEY-DOVEY",
            "ANTICIPATION","SMILE","SUBTLE","RECOMMEND",
            "SIMPLE","NICE","DIFFICULT"
        };

        private static String[] WORDS_TOUGH = new String[]
        {
            "EARTH TONES","IMPLANT","GOLDEN RATIO","OMNIBUS",
            "STARBOARD","MONEY RATE","RESOLUTION","CADENZA",
            "EDUCATION","CUBISM","CROSS-STITCH","ARTERY",
            "BONE DENSITY","GOMMAGE","STREAMING","CONDUCTIVITY",
            "COPYRIGHT","TWO-STEP","CONTOUR","NEUTRINO",
            "HOWLING","SPREADSHEET","GMT","IRRITABILITY",
            "FRACTALS","FLAMBE","STOCK PRICES","PH BALANCE",
            "VECTOR","POLYPHENOL","UBIQUITOUS","REM SLEEP"
        };

        private static String[] WORDS_UNION = new String[]
        {
            "SINGLE","DOUBLE","MIX BATTLE","MULTI BATTLE",
            "LEVEL 50","LEVEL 100","COLOSSEUM","POKéMON",
            "DRAWING","RECORD","GOTCHA","CHAT",
            "FRIEND CODE","CONNECTION","VOICE CHAT","WI-FI",
            "UNDERGROUND","UNION","POFFIN","CONTEST",
            "BATTLE TOWER","GTS","SECRET BASE"
        };
        #endregion
    }
}
