﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        string[] animals = { "aardvark", "buffalo", "alligator", "antelope", "armadillo", "baboon", "badger", "barracuda", "beaver", "bobcat", "bear", "butterfly", "camel", "caribou", "chicken", "chimpanzee", "cheetah", "crocodile", "coyote", "deer", "dingo", "doplphin", "donkey", "dragonfly", "eagle", "elephant", "falcon", "ferret", "flamingo", "fox", "gazelle", "goose", "gorilla", "grasshopper", "hamster", "hippopotamus", "horse", "hummingbird", "iguana", "impala", "jaguar", "jellyfish", "kangaroo", "koala", "ladybug", "leopard", "lion", "lobster", "llama", "magpie", "marmot", "mink", "mockingbird", "monkey", "mosquito", "mouse", "mule", "narwhal", "octopus", "opossum", "orca", "ostrich", "owl", "panda", "panther", "parrot", "peacock", "penguin", "pheasant", "pigeon", "platypus", "porcupine", "puma", "quail", "raccoon", "rattlesnake", "rhinoceros", "salamander", "seahorse", "sheep", "skunk", "sloth", "shrimp", "tiger", "toad", "toucan", "turkey", "vulture", "walrus", "whale", "weasel", "wolf", "wildebeest", "worm", "yak", "zebra" };
        string[] countries = { "afghanistan", "algeria", "argentia", "australia", "austria", "bangladesh", "belgium", "bolivia", "brazil", "bulgaria", "cambodia", "canada", "chad", "chile", "china", "cuba", "denmark", "ecuador", "ethiopia", "fiji", "finland", "france", "germany", "ghana", "greece", "guatemala", "haiti", "hungary", "iceland", "india", "israel", "italy", "indonesia", "jamaica", "japan", "kenya", "kyrgyzstan", "latvia", "lithuania", "madagascar", "mongolia", "mozambique", "mexico", "netherlands", "norway", "pakistan", "peru", "portugal", "russia", "singapore", "sweden", "slovenia", "thailand", "turkey", "uganda", "ukraine", "vietnam", "yemen", "zimbabwe" };
        string[] fruits = { "guava", "grapefruit", "clementine", "grape", "fig", "pear", "plum", "orange", "tangerine", "lemon", "lemon", "mango", "avocado", "cherry", "apple", "banana", "pineapple", "kiwi", "watermelon", "strawberry", "raspberry", "blueberry", };
        string[] random = {"aardvark", "abacus", "abbey", "abdomen", "ability", "abolishment", "abroad", "abuse", "accelerant", "accelerator", "access", "accident", "accommodation", "accompanist", "accordion", "account", "accountant", "achiever", "acid", "acknowledgment", "acoustic", "acoustics", "acrylic", "act", "action", "activity", "actor", "actress", "acupuncture", "ad", "adapter", "addiction", "addition", "address", "adjustment", "administration", "adrenalin", "adult", "adulthood", "advance", "advancement", "advantage", "advertisement", "advertising", "advice", "affair", "affect", "aftermath", "afternoon", "aftershave", "aftershock", "afterthought", "age", "agency", "agenda", "agent", "aggression", "aglet", "agreement", "aid", "air", "airbag", "airbus", "airfare", "airforce", "airline", "airmail", "airplane", "airport", "airship", "alarm", "alb", "albatross", "alcohol", "alcove", "alder", "algebra", "alibi", "allergist", "alley", "alligator", "alloy", "almanac", "almond", "alpaca", "alpenglow", "alpenhorn", "alpha", "alphabet", "alternative", "altitude", "alto", "aluminium", "aluminum", "ambassador", "ambition", "ambulance", "amendment", "amount", "amusement", "anagram", "analgesia", "analog", "analogue", "analogy", "analysis", "analyst", "anatomy", "anesthesiology", "anethesiologist", "anger", "angiosperm", "angle", "angora", "angstrom", "anguish", "animal", "anime", "ankle", "anklet", "annual", "anorak", "answer", "ant", "anteater", "antechamber", "antelope", "anthony", "anthropology", "antler", "anxiety", "anybody", "anything", "anywhere", "apartment", "ape", "aperitif", "apology", "apparatus", "apparel", "appeal", "appearance", "appendix", "applause", "apple", "applewood", "appliance", "application", "appointment", "approval", "apron", "apse", "aquifer", "arch", "archaeology", "archeology", "archer", "architect", "architecture", "arch-rival", "area", "argument", "arithmetic", "arm", "armadillo", "armament", "armchair", "armoire", "armor", "arm-rest", "army", "arrival", "arrow", "art", "artichoke", "article", "artificer", "ascot", "ash", "ashram", "ashtray", "aside", "ask", "asparagus", "aspect", "asphalt", "assignment", "assist", "assistance", "assistant", "associate", "association", "assumption", "asterisk", "astrakhan", "astrolabe", "astrologer", "astrology", "astronomy", "atelier", "athlete", "athletics", "atmosphere", "atom", "atrium", "attachment", "attack", "attempt", "attendant", "attention", "attenuation", "attic", "attitude", "attorney", "attraction", "audience", "auditorium", "aunt", "author", "authorisation", "authority", "authorization", "automaton", "avalanche", "avenue", "average", "award", "awareness", "azimuth", "babe", "baboon", "babushka", "baby", "back", "backbone", "backdrop", "background", "backpack", "bacon", "bad", "badge", "badger", "bafflement", "bag", "bagel", "baggage", "bagpipe", "bail", "bait", "bake", "baker", "bakery", "bakeware", "balaclava", "balalaika", "balance", "balcony", "ball", "ballet", "balloon", "ballpark", "bamboo", "banana", "band", "bandana", "bandanna", "bandolier", "bangle", "banjo", "bank", "bankbook", "banker", "banquette", "baobab", "bar", "barbeque", "barber", "barbiturate", "barge", "baritone", "barium", "barn", "barometer", "barracks", "barstool", "base", "baseball", "basement", "basin", "basis", "basket", "basketball", "bass", "bassinet", "bassoon", "bat", "bath", "bather", "bathhouse", "bathrobe", "bathroom", "bathtub", "batter", "battery", "batting", "battle", "battleship", "bay", "bayou", "beach", "bead", "beak", "beam", "bean", "beanie", "beanstalk", "bear", "beard", "beast", "beat", "beautiful", "beauty", "beaver", "bed", "bedroom", "bee", "beech", "beef", "beer", "beet", "beetle", "beggar", "beginner", "beginning", "begonia", "behavior", "beheading", "behest", "being", "belfry", "belief", "believe", "bell", "belligerency", "bellows", "belly", "belt", "bench", "bend", "beneficiary", "benefit", "bengal", "beret", "berry", "bestseller", "best-seller", "bet", "beverage", "beyond", "bibliography", "bicycle", "bid", "bidet", "bifocals", "big", "big-rig", "bijou", "bike", "bikini", "bill", "billboard", "bin", "biology", "biplane", "birch", "bird", "birdbath", "birdcage", "birdhouse", "bird-watcher", "birth", "birthday", "bit", "bite", "bitter", "black", "blackberry", "blackboard", "blackfish", "bladder", "blade", "blame", "blank", "blanket", "blazer", "blight", "blind", "blinker", "blister", "blizzard", "block", "blocker", "blood", "bloodflow", "bloom", "bloomers", "blossom", "blouse", "blow", "blowgun", "blowhole", "blue", "blueberry", "boar", "board", "boat", "boat-building", "boatload", "boatyard", "bobcat", "body", "bog", "bolero", "bolt", "bomb", "bomber", "bondsman", "bone", "bongo", "bonnet", "bonsai", "bonus", "boogeyman", "book", "bookcase", "bookend", "booklet", "booster", "boot", "bootee", "bootie", "boots", "booty", "border", "bore", "bosom", "boss", "botany", "bother", "bottle", "bottling", "bottom", "bottom-line", "boudoir", "bough", "boundary", "bow", "bower", "bowl", "bowler", "bowling", "bowtie", "box", "boxer", "boxspring", "boy", "boyfriend", "bra", "brace", "bracelet", "bracket", "brain", "brake", "branch", "brand", "brandy", "brass", "brassiere", "bratwurst", "brave", "bread", "breadcrumb", "break", "breakfast", "breakpoint", "breast", "breastplate", "breath", "breeze", "bribery", "brick", "bricklaying", "bridge", "brief", "briefs", "brilliant", "british", "broad", "broccoli", "brochure", "broiler", "broker", "brome", "bronchitis", "bronco", "bronze", "brooch", "brood", "brook", "broom", "brother", "brother-in-law", "brow", "brown", "brush", "brushfire", "brushing", "bubble", "bucket", "buckle", "bud", "buddy", "budget", "buffer", "buffet", "bug", "buggy", "bugle", "building", "bulb", "bull", "bulldozer", "bullet", "bull-fighter", "bumper", "bun", "bunch", "bungalow", "bunghole", "bunkhouse", "burglar", "burlesque", "burn", "burn-out", "burst", "bus", "bush", "business", "bust", "bustle", "butane", "butcher", "butter", "button", "buy", "buyer", "buzzard", "cabana", "cabbage", "cabin", "cabinet", "cable", "caboose", "cacao", "cactus", "caddy", "cadet", "cafe", "caftan", "cake", "calcification", "calculation", "calculator", "calculus", "calendar", "calf", "calico", "call", "calm", "camel", "cameo", "camera", "camp", "campaign", "campanile", "can", "canal", "cancel", "cancer", "candelabra", "candidate", "candle", "candy", "cane", "cannon", "canoe", "canon", "canopy", "canteen", "canvas", "cap", "cape", "capital", "capitulation", "capon", "cappelletti", "cappuccino", "captain", "caption", "car", "caravan", "carbon", "card", "cardboard", "cardigan", "care", "career", "cargo", "carload", "carnation", "carol", "carotene", "carp", "carpenter", "carpet", "carport", "carriage", "carrier", "carrot", "carry", "cart", "cartilage", "cartload", "cartoon", "cartridge", "cascade", "case", "casement", "cash", "cashier", "casino", "casserole", "cassock", "cast", "castanet", "castanets", "castle", "cat", "catacomb", "catamaran", "catch", "category", "caterpillar", "cathedral", "catsup", "cattle", "cauliflower", "cause", "caution", "cave", "c-clamp", "cd", "ceiling", "celebration", "celeriac", "celery", "celeste", "cell", "cellar", "cello", "celsius", "cement", "cemetery", "cenotaph", "census", "cent", "center", "centimeter", "centurion", "century", "cephalopod", "ceramic", "cereal", "certification", "cesspool", "chafe", "chain", "chainstay", "chair", "chairlift", "chairman", "chairperson", "chaise", "chalet", "chalice", "chalk", "challenge", "champion", "championship", "chance", "chandelier", "change", "channel", "chaos", "chap", "chapel", "chapter", "character", "chard", "charge", "charity", "charlatan", "charles", "charm", "chart", "chastity", "chasuble", "chateau", "chauffeur", "chauvinist", "check", "checkroom", "cheek", "cheetah", "chef", "chemical", "chemistry", "cheque", "cherries", "cherry", "chess", "chest", "chick", "chicken", "chicory", "chief", "chiffonier", "child", "childhood", "children", "chill", "chime", "chimpanzee", "chin", "chino", "chip", "chipmunk", "chit-chat", "chivalry", "chive", "chocolate", "choice", "choker", "chop", "chopstick", "chord", "chowder", "chrome", "chromolithograph", "chronograph", "chronometer", "chub", "chug", "church", "churn", "cicada", "cigarette", "cinema", "circle", "circulation", "circumference", "cirrus", "citizenship", "city", "civilisation", "claim", "clam", "clank", "clapboard", "clarinet", "clasp", "class", "classic", "classroom", "clause", "clave", "clavicle", "clavier", "cleaner", "cleat", "cleavage", "clef", "cleric", "clerk", "click", "client", "cliff", "climate", "climb", "clip", "clipper", "cloak", "cloakroom", "clock", "clockwork", "clogs", "cloister", "close", "closet", "cloth", "clothes", "clothing", "cloud", "cloudburst", "cloudy", "clove", "clover", "club", "clue", "clutch", "coach", "coal", "coast", "coat", "cob", "cobweb", "cockpit", "cockroach", "cocktail", "cocoa", "cod", "code", "codon", "codpiece", "coevolution", "coffee", "coffin", "coil", "coin", "coinsurance", "coke", "cold", "coliseum", "collar", "collection", "college", "collision", "colloquia", "colon", "colonisation", "colony", "color", "colt", "column", "columnist", "comb", "combat", "combination", "combine", "comfort", "comfortable", "comic", "comma", "command", "comment", "commerce", "commercial", "commission", "committee", "common", "communicant", "communication", "community", "company", "comparison", "compassion", "competition", "competitor", "complaint", "complement", "complex", "component", "comportment", "composer", "composition", "compost", "comprehension", "compulsion", "computer", "comradeship", "concentrate", "concept", "concern", "concert", "conclusion", "concrete", "condition", "condominium", "condor", "conductor", "cone", "confectionery", "conference", "confidence", "confirmation", "conflict", "confusion", "conga", "congo", "congress", "congressman", "congressperson", "conifer", "connection", "consent", "consequence", "consideration", "consist", "console", "consonant", "conspirator", "constant", "constellation", "construction", "consul", "consulate", "contact", "contact lens", "contagion", "content", "contest", "context", "continent", "contract", "contrail", "contrary", "contribution", "control", "convection", "conversation", "convert", "convertible", "cook", "cookie", "cooking", "coonskin", "cope", "cop-out", "copper", "co-producer", "copy", "copyright", "copywriter", "cord", "corduroy", "cork", "cormorant", "corn", "corner", "cornerstone", "cornet", "corral", "correspondent", "corridor", "corruption", "corsage", "cost", "costume", "cot", "cottage", "cotton", "couch", "cougar", "cough", "council", "councilman", "councilor", "councilperson", "count", "counter", "counter-force", "countess", "country", "county", "couple", "courage", "course", "court", "cousin", "covariate", "cover", "coverall", "cow", "cowbell", "cowboy", "crab", "crack", "cracker", "crackers", "cradle", "craft", "craftsman", "crash", "crate", "cravat", "craw", "crawdad", "crayfish", "crayon", "crazy", "cream", "creative", "creator", "creature", "creche", "credenza", "credit", "creditor", "creek", "creme brulee", "crest", "crew", "crib", "cribbage", "cricket", "cricketer", "crime", "criminal", "crinoline", "criteria", "criterion", "criticism", "crocodile", "crocus", "croissant", "crook", "crop", "cross", "cross-contamination", "cross-stitch", "crotch", "croup", "crow", "crowd", "crown", "crude", "crush", "cry", "crystallography", "cub", "cuckoo", "cucumber", "cuff-links", "cultivar", "cultivator", "culture", "culvert", "cummerbund", "cup", "cupboard", "cupcake", "cupola", "curio", "curl", "curler", "currency", "current", "cursor", "curtain", "curve", "cushion", "custard", "customer", "cut", "cuticle", "cutlet", "cutover", "cutting", "cyclamen", "cycle", "cyclone", "cylinder", "cymbal", "cymbals", "cynic", "cyst", "cytoplasm", "dad", "daffodil", "dagger", "dahlia", "daisy", "damage", "dame", "dance", "dancer", "dancing", "danger", "daniel", "dare", "dark", "dart", "dash", "dashboard", "data", "database", "date", "daughter", "david", "day", "daybed", "dead", "deadline", "deal", "dealer", "dear", "death", "deathwatch", "debate", "debt", "debtor", "decade", "decimal", "decision", "deck", "declination", "decongestant", "decrease", "decryption", "dedication", "deep", "deer", "defense", "deficit", "definition", "deformation", "degree", "delay", "delete", "delight", "delivery", "demand", "demur", "den", "denim", "dentist", "deodorant", "department", "departure", "dependent", "deployment", "deposit", "depression", "depressive", "depth", "deputy", "derby", "derrick", "description", "desert", "design", "designer", "desire", "desk", "dessert", "destiny", "destroyer", "destruction", "detail", "detainment", "detective", "detention", "determination", "development", "deviance", "device", "devil", "dew", "dhow", "diadem", "diamond", "diaphragm", "diarist", "dibble", "dickey", "dictaphone", "diction", "dictionary", "diet", "difference", "differential", "difficulty", "dig", "digestion", "digger", "digital", "dignity", "dilapidation", "dill", "dime", "dimension", "dimple", "diner", "dinghy", "dinner", "dinosaur", "diploma", "dipstick", "direction", "director", "dirndl", "dirt", "disadvantage", "disarmament", "disaster", "discipline", "disco", "disconnection", "discount", "discovery", "discrepancy", "discussion", "disease", "disembodiment", "disengagement", "disguise", "disgust", "dish", "dishes", "dishwasher", "disk", "display", "disposer", "distance", "distribution", "distributor", "district", "divan", "diver", "divide", "divider", "diving", "division", "dock", "doctor", "document", "doe", "dog", "dogsled", "dogwood", "doll", "dollar", "dolman", "dolphin", "domain", "donkey", "door", "doorknob", "doorpost", "dory", "dot", "double", "doubling", "doubt", "doubter", "downforce", "downgrade", "downtown", "draft", "drag", "dragon", "dragonfly", "dragster", "drain", "drake", "drama", "dramaturge", "draw", "drawbridge", "drawer", "drawing", "dream", "dredger", "dress", "dresser", "dressing", "drill", "drink", "drive", "driver", "driveway", "driving", "drizzle", "dromedary", "drop", "drug", "drum", "drummer", "drunk", "dry", "dryer", "duck", "duckling", "dud", "due", "duffel", "dugout", "dulcimer", "dumbwaiter", "dump", "dump truck", "dune buggy", "dungarees", "dungeon", "duplexer", "dust", "dust storm", "duster", "duty", "dwarf", "dwelling", "dynamo", "eagle", "ear", "eardrum", "earmuffs", "earplug", "earrings", "earth", "earthquake", "earthworm", "ease", "easel", "east", "eat", "eave", "eavesdropper", "e-book", "ecclesia", "eclipse", "ecliptic", "economics", "economy", "ecumenist", "eddy", "edge", "edger", "editor", "editorial", "education", "edward", "eel", "effacement", "effect", "effective", "efficacy", "efficiency", "effort", "egg", "egghead", "eggnog", "eggplant", "eight", "ejector", "elbow", "election", "electricity", "electrocardiogram", "element", "elephant", "elevator", "elixir", "elk", "ellipse", "elm", "elongation", "embossing", "emergence", "emergency", "emergent", "emery", "emotion", "emphasis", "employ", "employee", "employer", "employment", "empowerment", "emu", "encirclement", "encyclopedia", "end", "endothelium", "enemy", "energy", "engine", "engineer", "engineering", "enigma", "enjoyment", "enquiry", "entertainment", "enthusiasm", "entrance", "entry", "environment", "envy", "epauliere", "epee", "ephemera", "ephemeris", "epoch", "eponym", "epoxy", "equal", "equinox", "equipment", "equivalent", "era", "e-reader", "error", "escape", "ese", "espadrille", "espalier", "essay", "establishment", "estate", "estimate", "estrogen", "estuary", "ethernet", "ethics", "euphonium", "eurocentrism", "europe", "evaluator", "evening", "evening-wear", "event", "eviction", "evidence", "evocation", "evolution", "exam", "examination", "examiner", "example", "exchange", "excitement", "exclamation", "excuse", "executor", "exercise", "exhaust", "ex-husband", "exile", "existence", "exit", "expansion", "expansionism", "experience", "expert", "explanation", "exposition", "expression", "extension", "extent", "external", "extreme", "ex-wife", "eye", "eyeball", "eyebrow", "eyebrows", "eyeglasses", "eyelash", "eyelashes", "eyelid", "eyelids", "eyeliner", "eyestrain", "face", "facelift", "facet", "facilities", "facsimile", "fact", "factor", "factory", "faculty", "fahrenheit", "fail", "failure", "fairies", "fairy", "faith", "fall", "falling-out", "fame", "familiar", "family", "fan", "fang", "fanlight", "fanny", "fanny-pack", "farm", "farmer", "fascia", "fat", "father", "father-in-law", "fatigues", "faucet", "fault", "fawn", "fax", "fear", "feast", "feather", "feature", "fedelini", "fedora", "fee", "feed", "feedback", "feel", "feeling", "feet", "felony", "female", "fen", "fence", "fencing", "fender", "ferry", "ferryboat", "fertilizer", "few", "fiber", "fiberglass", "fibre", "fiction", "fiddle", "field", "fifth", "fight", "fighter", "figure", "figurine", "file", "fill", "filly", "film", "filth", "final", "finance", "find", "finding", "fine", "finger", "fingernail", "finish", "finisher", "fir", "fire", "fireman", "fireplace", "firewall", "fish", "fishbone", "fisherman", "fishery", "fishing", "fishmonger", "fishnet", "fisting", "fix", "fixture", "flag", "flame", "flanker", "flare", "flash", "flat", "flatboat", "flavor", "flax", "fleck", "fleece", "flesh", "flight", "flintlock", "flip-flops", "flock", "flood", "floor", "floozie", "flour", "flow", "flower", "flu", "flugelhorn", "fluke", "flute", "fly", "flytrap", "foam", "fob", "focus", "fog", "fold", "folder", "following", "fondue", "font", "food", "foot", "football", "footnote", "footrest", "foot-rest", "footstool", "foray", "force", "forearm", "forebear", "forecast", "forehead", "forest", "forestry", "forever", "forgery", "fork", "form", "formal", "format", "former", "fort", "fortnight", "fortress", "fortune", "forum", "foundation", "fountain", "fowl", "fox", "foxglove", "fragrance", "frame", "fratricide", "fraudster", "frazzle", "freckle", "freedom", "freeplay", "freeze", "freezer", "freight", "freighter", "freon", "fresco", "friction", "fridge", "friend", "friendship", "frigate", "fringe", "frock", "frog", "front", "frost", "frown", "fruit", "frustration", "fuel", "fulfillment", "full", "fun", "function", "fundraising", "funeral", "funny", "fur", "furnace", "furniture", "fusarium", "futon", "future", "gaffer", "gain", "gaiters", "gale", "gall-bladder", "gallery", "galley", "gallon", "galn", "galoshes", "game", "gamebird", "gamma-ray", "gander", "gap", "garage", "garb", "garbage", "garden", "garlic", "garment", "garter", "gas", "gasoline", "gastropod", "gate", "gateway", "gather", "gauge", "gauntlet", "gazebo", "gazelle", "gear", "gearshift", "geese", "gelding", "gem", "gemsbok", "gender", "gene", "general", "genetics", "geography", "geology", "geometry", "george", "geranium", "gerbil", "geyser", "gherkin", "ghost", "giant", "gift", "gigantism", "ginseng", "giraffe", "girdle", "girl", "girlfriend", "git", "give", "glad", "gladiolus", "gland", "glass", "glasses", "glen", "glider", "gliding", "glockenspiel", "glove", "gloves", "glue", "glut", "go", "goal", "goat", "gobbler", "god", "godmother", "goggles", "go-kart", "gold", "goldfish", "golf", "gondola", "gong", "good", "goodbye", "good-bye", "goodie", "goose", "gopher", "gore-tex", "gorilla", "gosling", "gossip", "governance", "government", "governor", "gown", "grab", "grab-bag", "grade", "grain", "gram", "grammar", "grand", "granddaughter", "grandfather", "grandmom", "grandmother", "grandson", "granny", "grape", "grapefruit", "graph", "graphic", "grass", "grasshopper", "grassland", "gratitude", "gray", "grease", "great", "great-grandfather", "great-grandmother", "greek", "green", "greenhouse", "grenade", "grey", "grief", "grill", "grip", "grit", "grocery", "ground", "group", "grouper", "grouse", "growth", "guarantee", "guard", "guess", "guest", "guestbook", "guidance", "guide", "guilt", "guilty", "guitar", "guitarist", "gum", "gumshoes", "gun", "gutter", "guy", "gym", "gymnast", "gymnastics", "gynaecology", "gyro", "habit", "hacienda", "hacksaw", "hackwork", "hail", "hair", "haircut", "half", "half-brother", "half-sister", "halibut", "hall", "hallway", "hamaki", "hamburger", "hammer", "hammock", "hamster", "hand", "handball", "hand-holding", "handicap", "handle", "handlebar", "handmaiden", "handsaw", "hang", "happiness", "harbor", "harbour", "hardboard", "hardcover", "hardening", "hardhat", "hard-hat", "hardware", "harm", "harmonica", "harmony", "harp", "harpooner", "harpsichord", "hassock", "hat", "hatbox", "hatchet", "hate", "hatred", "haunt", "haversack", "hawk", "hay", "head", "headlight", "headline", "headrest", "health", "hearing", "heart", "heartache", "hearth", "hearthside", "heart-throb", "heartwood", "heat", "heater", "heaven", "heavy", "hedge", "hedgehog", "heel", "height", "heirloom", "helen", "helicopter", "helium", "hell", "hellcat", "hello", "helmet", "helo", "help", "hemp", "hen", "herb", "heron", "herring", "hexagon", "heyday", "hide", "high", "highlight", "high-rise", "highway", "hill", "hip", "hippodrome", "hippopotamus", "hire", "history", "hit", "hive", "hobbies", "hobbit", "hobby", "hockey", "hoe", "hog", "hold", "hole", "holiday", "home", "homework", "homogenate", "homonym", "honesty", "honey", "honeybee", "honoree", "hood", "hoof", "hook", "hope", "hops", "horn", "hornet", "horror", "horse", "hose", "hosiery", "hospice", "hospital", "hospitality", "host", "hostel", "hostess", "hot", "hot-dog", "hotel", "hour", "hourglass", "house", "houseboat", "housework", "housing", "hovel", "hovercraft", "howitzer", "hub", "hubcap", "hugger", "human", "humidity", "humor", "humour", "hunger", "hunt", "hurdler", "hurricane", "hurry", "hurt", "husband", "hut", "hutch", "hyacinth", "hybridisation", "hydrant", "hydraulics", "hydrofoil", "hydrogen", "hyena", "hygienic", "hyphenation", "hypochondria", "hypothermia", "ice", "icebreaker", "icecream", "ice-cream", "icicle", "icon", "idea", "ideal", "if", "igloo", "ikebana", "illegal", "image", "imagination", "impact", "implement", "importance", "impress", "impression", "imprisonment", "improvement", "impudence", "impulse", "inbox", "incandescence", "inch", "incident", "income", "increase", "independence", "independent", "index", "indication", "indigence", "individual", "industry", "inevitable", "infancy", "inflammation", "inflation", "influence", "information", "infusion", "inglenook", "ingrate", "initial", "initiative", "in-joke", "injury", "injustice", "ink", "in-laws", "inlay", "inn", "innervation", "innocence", "innocent", "input", "inquiry", "inscription", "insect", "inside", "insolence", "inspection", "inspector", "instance", "instruction", "instrument", "instrumentalist", "instrumentation", "insulation", "insurance", "insurgence", "intelligence", "intention", "interaction", "interactive", "interest", "interferometer", "interior", "interloper", "internal", "international", "internet", "interpreter", "intervenor", "interview", "interviewer", "intestine", "intestines", "introduction", "invention", "inventor", "inventory", "investment", "invite", "invoice", "iridescence", "iris", "iron", "ironclad", "irony", "island", "issue", "it", "item", "jackal", "jacket", "jaguar", "jail", "jailhouse", "jam", "james", "jar", "jasmine", "jaw", "jealousy", "jeans", "jeep", "jeff", "jelly", "jellyfish", "jet", "jewel", "jewelry", "jiffy", "job", "jockey", "jodhpurs", "joey", "jogging", "join", "joint", "joke", "jot", "journey", "joy", "judge", "judgment", "judo", "juggernaut", "juice", "jumbo", "jump", "jumper", "jumpsuit", "junior", "junk", "junker", "junket", "jury", "justice", "jute", "kale", "kamikaze", "kangaroo", "karate", "karen", "kayak", "kazoo", "keep", "kendo", "ketch", "ketchup", "kettle", "kettledrum", "key", "keyboard", "keyboarding", "keystone", "kick", "kick-off", "kid", "kidney", "kidneys", "kielbasa", "kill", "kilogram", "kilometer", "kilt", "kimono", "kind", "kindness", "king", "kingfish", "kiosk", "kiss", "kitchen", "kite", "kitten", "kitty", "kleenex", "klomps", "knee", "kneejerk", "knickers", "knife", "knife-edge", "knight", "knitting", "knot", "knowledge", "knuckle", "koala", "kohlrabi", "lab", "laborer", "labour", "lace", "lack", "lacquerware", "ladder", "lady", "ladybug", "lake", "lamb", "lamp", "lan", "lanai", "land", "landform", "landmine", "landscape", "language", "lantern", "lap", "laparoscope", "lapdog", "laptop", "larch", "larder", "lark", "laryngitis", "lasagna", "latency", "latex", "lathe", "latte", "laugh", "laughter", "laundry", "lava", "law", "lawn", "lawsuit", "lawyer", "lay", "layer", "lead", "leader", "leadership", "leading", "leaf", "league", "leaker", "learning", "leash", "leather", "leave", "leaver", "lecture", "leek", "leg", "legal", "legging", "legume", "lei", "leisure", "lemon", "lemonade", "lemur", "length", "lentil", "leprosy", "lesson", "let", "letter", "lettuce", "level", "lever", "leverage", "license", "lie", "lier", "life", "lift", "light", "lighting", "lightning", "lilac", "lily", "limit", "limo", "line", "linen", "liner", "linguistics", "link", "linseed", "lion", "lip", "lipstick", "liquid", "liquor", "lisa", "list", "listen", "literature", "litigation", "litter", "liver", "livestock", "living", "lizard", "llama", "load", "loaf", "loafer", "loan", "lobotomy", "lobster", "local", "location", "lock", "locker", "locket", "locomotive", "locust", "loft", "log", "loggia", "logic", "loincloth", "loneliness", "long", "look", "loss", "lot", "lotion", "lounge", "lout", "love", "low", "loyalty", "luck", "luggage", "lumber", "lumberman", "lunch", "luncheonette", "lunchroom", "lung", "lunge", "lute", "luttuce", "lycra", "lye", "lymphocyte", "lynx", "lyocell", "lyre", "lyric", "macadamia", "macaroni", "machine", "machinery", "macrame", "macrofauna", "maelstrom", "maestro", "magazine", "magic", "maid", "maiden", "mail", "mailbox", "mailman", "main", "maintenance", "major", "major-league", "make", "makeup", "male", "mall", "mallet", "mambo", "mammoth", "man", "management", "manager", "mandarin", "mandolin", "mangrove", "manhunt", "maniac", "manicure", "mankind", "manner", "manor", "mansard", "manservant", "mansion", "mantel", "mantle", "mantua", "manufacturer", "manx", "many", "map", "maple", "maraca", "maracas", "marble", "mare", "margin", "mariachi", "marimba", "mark", "market", "marketing", "marksman", "marriage", "marsh", "marshland", "marxism", "mascara", "mask", "mass", "massage", "master", "mastication", "mastoid", "mat", "match", "mate", "material", "math", "mathematics", "matter", "mattock", "mattress", "maximum", "maybe", "mayonnaise", "mayor", "meal", "meaning", "measles", "measure", "measurement", "meat", "mechanic", "media", "medicine", "medium", "meet", "meeting", "megaliac", "melody", "member", "membership", "memory", "men", "menorah", "mention", "menu", "mercury", "mess", "message", "metal", "metallurgist", "meteor", "meteorology", "meter", "methane", "method", "methodology", "metro", "metronome", "mezzanine", "mice", "microlending", "microwave", "mid-course", "middle", "middleman", "midi", "midline", "midnight", "midwife", "might", "migrant", "mile", "milk", "milkshake", "millennium", "millimeter", "millisecond", "mime", "mimosa", "mind", "mine", "mini", "minibus", "minimum", "minion", "mini-skirt", "minister", "minor", "minor-league", "mint", "minute", "mirror", "miscarriage", "miscommunication", "misfit", "misogyny", "misplacement", "misreading", "miss", "missile", "mission", "mist", "mistake", "mister", "miter", "mitten", "mix", "mixer", "mixture", "moat", "mobile", "moccasins", "mocha", "mode", "model", "modem", "mole", "mom", "moment", "monastery", "monasticism", "money", "monger", "monitor", "monkey", "monocle", "monotheism", "monsoon", "monster", "month", "mood", "moon", "moonscape", "moonshine", "mop", "morning", "morsel", "mortgage", "mortise", "mosque", "mosquito", "most", "motel", "moth", "mother", "mother-in-law", "motion", "motor", "motorboat", "motorcar", "motorcycle", "mound", "mountain", "mouse", "mouser", "mousse", "moustache", "mouth", "mouton", "move", "mover", "movie", "mower", "mud", "mug", "mukluk", "mule", "multimedia", "muscle", "musculature", "museum", "music", "music-box", "music-making", "mustache", "mustard", "mutt", "mycoplasma", "n", "nail", "name", "naming", "nanoparticle", "napkin", "nasty", "nation", "national", "native", "natural", "naturalisation", "nature", "neat", "necessary", "neck", "necklace", "necktie", "need", "needle", "negative", "negligee", "negotiation", "neologism", "neon", "nephew", "nerve", "nest", "net", "netball", "netbook", "netsuke", "network", "neurobiologist", "neuropathologist", "neuropsychiatry", "news", "newspaper", "newsprint", "newsstand", "nexus", "nicety", "niche", "nickel", "niece", "night", "nightclub", "nightgown", "nightingale", "nightlight", "nitrogen", "nobody", "node", "noise", "nonbeliever", "nonconformist", "nondisclosure", "nonsense", "noodle", "normal", "norse", "north", "nose", "note", "notebook", "nothing", "notice", "notify", "notoriety", "nougat", "novel", "nudge", "number", "numeracy", "numeric", "numismatist", "nurse", "nursery", "nurture", "nut", "nutrition", "nylon", "oak", "oar", "oasis", "oatmeal", "obedience", "obesity", "obi", "object", "objective", "obligation", "oboe", "observation", "observatory", "occasion", "occupation", "ocean", "ocelot", "octagon", "octave", "octavo", "octet", "octopus", "odometer", "oeuvre", "offence", "offer", "office", "officer", "official", "off-ramp", "oil", "okra", "oldie", "olive", "omega", "omelet", "oncology", "one", "onion", "open", "opening", "opera", "operation", "ophthalmologist", "opinion", "opium", "opossum", "opportunist", "opportunity", "opposite", "option", "orange", "orangutan", "orator", "orchard", "orchestra", "orchid", "order", "ordinary", "ordination", "organ", "organisation", "organization", "original", "ornament", "osmosis", "osprey", "ostrich", "other", "others", "ott", "otter", "ounce", "outback", "outcome", "outfit", "outhouse", "outlay", "output", "outrigger", "outset", "outside", "oval", "ovary", "oven", "overcharge", "overclocking", "overcoat", "overexertion", "overflight", "overnighter", "overshoot", "owl", "owner", "ox", "oxen", "oxford", "oxygen", "oyster", "pace", "pacemaker", "pack", "package", "packet", "pad", "paddle", "paddock", "page", "pagoda", "pail", "pain", "paint", "painter", "painting", "paintwork", "pair", "pajama", "pajamas", "palm", "pamphlet", "pan", "pancake", "pancreas", "panda", "panic", "pannier", "panpipe", "pansy", "panther", "panties", "pantologist", "pantology", "pantry", "pants", "pantsuit", "panty", "pantyhose", "paper", "paperback", "parable", "parachute", "parade", "parallelogram", "paramedic", "parcel", "parchment", "pard", "parent", "parentheses", "park", "parka", "parking", "parrot", "parsnip", "part", "participant", "particle", "particular", "partner", "partridge", "party", "pass", "passage", "passbook", "passenger", "passion", "passive", "past", "pasta", "paste", "pastor", "pastoralist", "pastry", "patch", "path", "patience", "patient", "patina", "patio", "patriarch", "patricia", "patrimony", "patriot", "patrol", "pattern", "pause", "pavement", "pavilion", "paw", "pawnshop", "pay", "payee", "payment", "pea", "peace", "peach", "peacoat", "peacock", "peak", "peanut", "pear", "pearl", "pedal", "peen", "peer", "peer-to-peer", "pegboard", "pelican", "pelt", "pen", "penalty", "pencil", "pendant", "pendulum", "penicillin", "pension", "pentagon", "peony", "people", "pepper", "percentage", "perception", "perch", "performance", "perfume", "period", "periodical", "peripheral", "permafrost", "permission", "permit", "perp", "person", "personal", "personality", "perspective", "pest", "pet", "petal", "petticoat", "pew", "pha", "pharmacist", "pharmacopoeia", "phase", "pheasant", "philosopher", "philosophy", "phone", "photo", "photographer", "phrase", "physical", "physics", "pianist", "piano", "piccolo", "pick", "pickax", "picket", "pickle", "picture", "pie", "piece", "pier", "piety", "pig", "pigeon", "pike", "pile", "pilgrimage", "pillbox", "pillow", "pilot", "pimp", "pimple", "pin", "pinafore", "pince-nez", "pine", "pineapple", "pinecone", "ping", "pink", "pinkie", "pinstripe", "pint", "pinto", "pinworm", "pioneer", "pipe", "piracy", "piss", "pitch", "pitching", "pith", "pizza", "place", "plain", "plan", "plane", "planet", "plant", "plantation", "planter", "plaster", "plasterboard", "plastic", "plate", "platform", "platinum", "platypus", "play", "player", "playground", "playroom", "pleasure", "pleated", "plenty", "plier", "plot", "plough", "plover", "plow", "plowman", "plume", "plunger", "plywood", "pneumonia", "pocket", "pocketbook", "pocket-watch", "poem", "poet", "poetry", "poignance", "point", "poison", "poisoning", "pole", "polenta", "police", "policeman", "policy", "polish", "politics", "pollution", "polo", "polyester", "pompom", "poncho", "pond", "pony", "poof", "pool", "pop", "popcorn", "poppy", "popsicle", "population", "populist", "porch", "porcupine", "port", "porter", "portfolio", "porthole", "position", "positive", "possession", "possibility", "possible", "post", "postage", "postbox", "poster", "pot", "potato", "potential", "potty", "pouch", "poultry", "pound", "pounding", "poverty", "powder", "power", "practice", "precedent", "precipitation", "preface", "preference", "prelude", "premeditation", "premier", "preoccupation", "preparation", "presence", "present", "presentation", "president", "press", "pressroom", "pressure", "pressurisation", "price", "pride", "priest", "priesthood", "primary", "primate", "prince", "princess", "principal", "principle", "print", "printer", "prior", "priority", "prison", "private", "prize", "prizefight", "probation", "problem", "procedure", "process", "processing", "produce", "producer", "product", "production", "profession", "professional", "professor", "profile", "profit", "program", "progress", "project", "promise", "promotion", "prompt", "pronunciation", "proof", "proof-reader", "propane", "property", "proposal", "prose", "prosecution", "protection", "protest", "protocol", "prow", "pruner", "pseudoscience", "psychiatrist", "psychoanalyst", "psychologist", "psychology", "ptarmigan", "public", "publicity", "publisher", "pudding", "puddle", "puffin", "pull", "pulley", "puma", "pump", "pumpkin", "pumpkinseed", "punch", "punctuation", "punishment", "pupa", "pupil", "puppy", "purchase", "puritan", "purple", "purpose", "purse", "push", "pusher", "put", "pvc", "pyjama", "pyramid", "quadrant", "quail", "quality", "quantity", "quart", "quarter", "quartz", "queen", "question", "quicksand", "quiet", "quill", "quilt", "quince", "quit", "quiver", "quotation", "quote", "rabbi", "rabbit", "raccoon", "race", "racer", "racing", "racism", "racist", "rack", "radar", "radiator", "radio", "radiosonde", "radish", "raffle", "raft", "rag", "rage", "rail", "railway", "raiment", "rain", "rainbow", "raincoat", "rainmaker", "rainstorm", "raise", "rake", "ram", "rambler", "ramie", "ranch", "random", "randomisation", "range", "rank", "raspberry", "rat", "rate", "ratio", "raven", "ravioli", "raw", "rawhide", "ray", "rayon", "reach", "reactant", "reaction", "read", "reading", "reality", "reamer", "rear", "reason", "receipt", "reception", "recess", "recipe", "recliner", "recognition", "recommendation", "record", "recorder", "recording", "recover", "recreation", "recruit", "rectangle", "red", "redesign", "rediscovery", "reduction", "reef", "refectory", "reference", "reflection", "refrigerator", "refund", "refuse", "region", "register", "regret", "regular", "regulation", "reindeer", "reinscription", "reject", "relation", "relationship", "relative", "relaxation", "release", "reliability", "relief", "religion", "relish", "reminder", "remote", "remove", "rent", "repair", "reparation", "repeat", "replace", "replacement", "replication", "reply", "report", "representative", "reprocessing", "republic", "reputation", "request", "requirement", "resale", "research", "reserve", "resident", "resist", "resolution", "resolve", "resort", "resource", "respect", "respite", "respond", "response", "responsibility", "rest", "restaurant", "result", "retailer", "rethinking", "retina", "retouch", "return", "reveal", "revenant", "revenge", "revenue", "review", "revolution", "revolve", "revolver", "reward", "rheumatism", "rhinoceros", "rhyme", "rhythm", "rice", "rich", "riddle", "ride", "rider", "ridge", "rifle", "right", "rim", "ring", "ringworm", "rip", "ripple", "rise", "riser", "risk", "river", "riverbed", "rivulet", "road", "roadway", "roast", "robe", "robin", "rock", "rocker", "rocket", "rocket-ship", "rod", "role", "roll", "roller", "roof", "room", "rooster", "root", "rope", "rose", "rostrum", "rotate", "rough", "round", "roundabout", "route", "router", "routine", "row", "rowboat", "royal", "rub", "rubber", "rubbish", "rubric", "ruckus", "ruffle", "rugby", "ruin", "rule", "rum", "run", "runaway", "runner", "rush", "rutabaga", "ruth", "ry", "sabre", "sack", "sad", "saddle", "safe", "safety", "sage", "sail", "sailboat", "sailor", "salad", "salary", "sale", "salesman", "salmon", "salon", "saloon", "salt", "samovar", "sampan", "sample", "samurai", "sand", "sandals", "sandbar", "sandwich", "sardine", "sari", "sarong", "sash", "satellite", "satin", "satire", "satisfaction", "sauce", "sausage", "save", "saving", "savings", "savior", "saviour", "saw", "saxophone", "scale", "scallion", "scanner", "scarecrow", "scarf", "scarification", "scene", "scenery", "scent", "schedule", "scheme", "schizophrenic", "schnitzel", "school", "schoolhouse", "schooner", "science", "scimitar", "scissors", "scooter", "score", "scorn", "scow", "scraper", "scratch", "screamer", "screen", "screenwriting", "screw", "screwdriver", "screw-up", "scrim", "scrip", "script", "sculpting", "sculpture", "sea", "seafood", "seagull", "seal", "seaplane", "search", "seashore", "seaside", "season", "seat", "second", "secret", "secretariat", "secretary", "section", "sectional", "sector", "secure", "security", "seed", "seeder", "segment", "select", "selection", "self", "sell", "semicircle", "semicolon", "senator", "senior", "sense", "sensitive", "sentence", "sepal", "septicaemia", "series", "servant", "serve", "server", "service", "session", "set", "setting", "settler", "sewer", "sex", "shack", "shade", "shadow", "shadowbox", "shake", "shakedown", "shaker", "shallot", "shame", "shampoo", "shanty", "shape", "share", "shark", "sharon", "shawl", "she", "shearling", "shears", "sheath", "shed", "sheep", "sheet", "shelf", "shell", "shelter", "sherry", "shield", "shift", "shin", "shine", "shingle", "ship", "shirt", "shirtdress", "shoat", "shock", "shoe", "shoehorn", "shoe-horn", "shoelace", "shoemaker", "shoes", "shoestring", "shofar", "shoot", "shootdown", "shop", "shopper", "shopping", "shore", "shortage", "shorts", "shortwave", "shot", "shoulder", "shovel", "show", "shower", "show-stopper", "shred", "shrimp", "shrine", "sibling", "sick", "side", "sideboard", "sideburns", "sidecar", "sidestream", "sidewalk", "siding", "sign", "signal", "signature", "signet", "significance", "signup", "silence", "silica", "silk", "silkworm", "sill", "silly", "silo", "silver", "simple", "sing", "singer", "single", "sink", "sir", "sister", "sister-in-law", "sitar", "site", "situation", "size", "skate", "skiing", "skill", "skin", "skirt", "skull", "skullcap", "skullduggery", "skunk", "sky", "skylight", "skyscraper", "skywalk", "slapstick", "slash", "slave", "sled", "sledge", "sleep", "sleet", "sleuth", "slice", "slide", "slider", "slime", "slip", "slipper", "slippers", "slope", "sloth", "smash", "smell", "smelting", "smile", "smock", "smog", "smoke", "smoking", "smuggling", "snail", "snake", "snakebite", "sneakers", "sneeze", "snob", "snorer", "snow", "snowboarding", "snowflake", "snowman", "snowmobiling", "snowplow", "snowstorm", "snowsuit", "snuggle", "soap", "soccer", "society", "sociology", "sock", "socks", "soda", "sofa", "soft", "softball", "softdrink", "softening", "software", "soil", "soldier", "solid", "solitaire", "solution", "sombrero", "somersault", "somewhere", "son", "song", "songbird", "sonnet", "soot", "soprano", "sorbet", "sorrow", "sort", "soulmate", "sound", "soup", "source", "sourwood", "sousaphone", "south", "south america", "south korea", "sow", "soy", "soybean", "space", "spacing", "spade", "spaghetti", "spandex", "spank", "spare", "spark", "sparrow", "spasm", "speaker", "speakerphone", "spear", "special", "specialist", "specific", "spectacle", "spectacles", "spectrograph", "speech", "speed", "speedboat", "spell", "spelling", "spend", "sphere", "sphynx", "spider", "spike", "spinach", "spine", "spiral", "spirit", "spiritual", "spite", "spleen", "split", "sponge", "spoon", "sport", "spot", "spotlight", "spray", "spread", "spring", "sprinter", "sprout", "spruce", "spume", "spur", "spy", "square", "squash", "squatter", "squeegee", "squid", "squirrel", "stable", "stack", "stacking", "stadium", "staff", "stag", "stage", "stain", "stair", "staircase", "stallion", "stamen", "stamina", "stamp", "stance", "stand", "standard", "standoff", "star", "start", "starter", "state", "statement", "station", "station-wagon", "statistic", "status", "stay", "steak", "steal", "steam", "steamroller", "steel", "steeple", "stem", "stencil", "step", "step-aunt", "step-brother", "stepdaughter", "step-daughter", "step-father", "step-grandfather", "step-grandmother", "stepmother", "step-mother", "stepping-stone", "steps", "step-sister", "stepson", "step-son", "step-uncle", "stew", "stick", "stiletto", "still", "stinger", "stitch", "stock", "stocking", "stockings", "stock-in-trade", "stole", "stomach", "stone", "stonework", "stool", "stop", "stopsign", "stopwatch", "storage", "store", "storey", "storm", "story", "storyboard", "story-telling", "stove", "strain", "strait", "stranger", "strap", "strategy", "straw", "strawberry", "stream", "street", "streetcar", "strength", "stress", "stretch", "strike", "string", "strip", "stroke", "structure", "struggle", "stud", "student", "studio", "study", "stuff", "stumbling", "stupid", "stupidity", "sturgeon", "style", "styling", "stylus", "subcomponent", "subconscious", "subject", "submarine", "subroutine", "subsidence", "substance", "suburb", "subway", "success", "suck", "suede", "suffocation", "sugar", "suggestion", "suit", "suitcase", "sultan", "summer", "sun", "sunbeam", "sunbonnet", "sunday", "sundial", "sunflower", "sunglasses", "sunlamp", "sunroom", "sunshine", "supermarket", "supply", "support", "supporter", "suppression", "surface", "surfboard", "surgeon", "surgery", "surname", "surprise", "surround", "survey", "sushi", "suspect", "suspenders", "sustainment", "SUV", "swallow", "swamp", "swan", "swath", "sweat", "sweater", "sweats", "sweatshirt", "sweatshop", "sweatsuit", "swedish", "sweet", "sweets", "swell", "swim", "swimming", "swimsuit", "swing", "swiss", "switch", "switchboard", "swivel", "sword", "swordfish", "sycamore", "symmetry", "sympathy", "syndicate", "synergy", "synod", "syrup", "system", "tabby", "tabernacle", "table", "tablecloth", "tabletop", "tachometer", "tackle", "tadpole", "tail", "tailor", "tailspin", "tale", "talk", "tam", "tambour", "tambourine", "tam-o'-shanter", "tandem", "tangerine", "tank", "tanker", "tankful", "tank-top", "tap", "tard", "target", "task", "tassel", "taste", "tatami", "tattler", "tattoo", "tavern", "tax", "taxi", "taxicab", "tea", "teach", "teacher", "teaching", "team", "tear", "technologist", "technology", "teen", "teeth", "telephone", "telescreen", "teletype", "television", "tell", "teller", "temp", "temper", "temperature", "temple", "tempo", "temporariness", "temporary", "temptress", "tendency", "tenement", "tennis", "tenor", "tension", "tent", "tepee", "term", "terracotta", "terrapin", "territory", "test", "text", "textbook", "texture", "thanks", "thaw", "theater", "theism", "theme", "theory", "therapist", "thermals", "thermometer", "thigh", "thing", "thinking", "thirst", "thistle", "thomas", "thong", "thongs", "thorn", "thought", "thread", "thrill", "throat", "throne", "thrush", "thumb", "thunder", "thunderbolt", "thunderhead", "thunderstorm", "tiara", "tic", "ticket", "tie", "tiger", "tight", "tights", "tile", "till", "timbale", "timber", "time", "timeline", "timeout", "timer", "timpani", "tin", "tinderbox", "tinkle", "tintype", "tip", "tire", "tissue", "titanium", "title", "toad", "toast", "today", "toe", "toenail", "toga", "togs", "toilet", "tolerance", "tom", "tomato", "tomography", "tomorrow", "tom-tom", "ton", "tone", "tongue", "tonight", "tool", "toot", "tooth", "toothbrush", "toothpaste", "toothpick", "top", "top-hat", "topic", "topsail", "toque", "torchiere", "toreador", "tornado", "torso", "tortellini", "tortoise", "tosser", "total", "tote", "touch", "tough", "tough-guy", "tour", "tourist", "towel", "tower", "town", "townhouse", "tow-truck", "toy", "trachoma", "track", "tracksuit", "tractor", "trade", "tradition", "traditionalism", "traffic", "trail", "trailer", "train", "trainer", "training", "tram", "tramp", "transaction", "transition", "translation", "transmission", "transom", "transport", "transportation", "trapdoor", "trapezium", "trapezoid", "trash", "travel", "tray", "treat", "treatment", "tree", "trellis", "tremor", "trench", "trial", "triangle", "tribe", "trick", "trigonometry", "trim", "trinket", "trip", "tripod", "trolley", "trombone", "trooper", "trouble", "trousers", "trout", "trove", "trowel", "truck", "truckit", "trumpet", "trunk", "trust", "truth", "try", "t-shirt", "tsunami", "tub", "tuba", "tube", "tugboat", "tulip", "tummy", "tuna", "tune", "tune-up", "tunic", "tunnel", "turban", "turkish", "turn", "turnip", "turnover", "turnstile", "turret", "turtle", "tussle", "tutu", "tuxedo", "tv", "twig", "twilight", "twine", "twist", "twister", "two", "type", "typewriter", "typhoon", "tyvek", "ukulele", "umbrella", "unblinking", "uncle", "underclothes", "underground", "underneath", "underpants", "underpass", "undershirt", "understanding", "underwear", "underwire", "unemployment", "unibody", "uniform", "union", "unique", "unit", "unity", "university", "upper", "upstairs", "urn", "usage", "use", "user", "usher", "usual", "utensil", "vacation", "vacuum", "vagrant", "valance", "validity", "valley", "valuable", "value", "van", "vane", "vanity", "variation", "variety", "vase", "vast", "vault", "vaulting", "veal", "vegetable", "vegetarianism", "vegetation", "vehicle", "veil", "vein", "veldt", "vellum", "velodrome", "velvet", "vengeance", "venom", "veranda", "verdict", "vermicelli", "verse", "version", "vertigo", "verve", "vessel", "vest", "vestment", "vibe", "vibraphone", "vibration", "video", "view", "villa", "village", "vineyard", "vinyl", "viola", "violence", "violet", "violin", "virginal", "virtue", "virus", "viscose", "vise", "vision", "visit", "visitor", "visor", "visual", "vitality", "vixen", "voice", "volcano", "volleyball", "volume", "voyage", "vulture", "wad", "wafer", "waffle", "waist", "waistband", "wait", "waiter", "waitress", "wake", "walk", "walker", "walkway", "wall", "wallaby", "wallet", "walnut", "walrus", "wampum", "wannabe", "war", "warden", "warlock", "warmth", "warm-up", "warning", "wash", "washbasin", "washcloth", "washer", "washtub", "wasp", "waste", "wastebasket", "watch", "watchmaker", "water", "waterbed", "waterfall", "waterskiing", "waterspout", "wave", "wax", "way", "weakness", "wealth", "weapon", "wear", "weasel", "weather", "web", "wedding", "wedge", "weed", "weeder", "weedkiller", "week", "weekend", "weekender", "weight", "weird", "welcome", "welfare", "well", "west", "western", "wet-bar", "wetsuit", "whale", "wharf", "wheat", "wheel", "whereas", "while", "whip", "whirlpool", "whirlwind", "whisker", "whiskey", "whistle", "white", "whole", "wholesale", "wholesaler", "whorl", "width", "wife", "wilderness", "wildlife", "will", "willow", "win", "wind", "windage", "wind-chime", "window", "windscreen", "windshield", "wine", "wing", "wingman", "wingtip", "winner", "winter", "wire", "wisdom", "wiseguy", "wish", "wisteria", "witch", "witch-hunt", "withdrawal", "witness", "wolf", "wombat", "women", "wonder", "wood", "woodland", "woodshed", "woodwind", "wool", "woolen", "word", "work", "workbench", "worker", "workhorse", "working", "worklife", "workshop", "world", "worm", "worry", "worth", "worthy", "wound", "wrap", "wraparound", "wrecker", "wren", "wrench", "wrestler", "wrinkle", "wrist", "writer", "writing", "wrong", "xylophone", "yacht", "yak", "yam", "yard", "yarmulke", "yarn", "yawl", "year", "yeast", "yellow", "yesterday", "yew", "yin", "yoga", "yogurt", "yoke", "you", "young", "youth", "yurt", "zampone", "zebra", "zebrafish", "zephyr", "ziggurat", "zinc", "zipper", "zither", "zone", "zoo", "zoologist", "zoology", "zoot-suit"};

        Random rn = new Random();
        int i, wrongGuesses;
        char guess;
        string word, displayString;
        char[] disp, wordChar, oldDisp;
        List<char> charList = new List<char>(); 
        Object obj = new Object();
        EventArgs ea = new EventArgs();

        public Form1()
        {
            InitializeComponent();
            DisableButtons();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            radRandom.Checked = true;
            radMedium.Checked = true;
        }

        public void DisableButtons()
        {
            this.KeyPreview = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //randomly choose word from word list
            if (radAnimals.Checked)
            {
                word = animals[rn.Next(animals.Length)];
            }
            else if (radFruits.Checked)
            {
                word = fruits[rn.Next(fruits.Length)];
            }
            else if (radCountries.Checked)
            {
                word = countries[rn.Next(countries.Length)];
            }
            else
            {
                word = random[rn.Next(random.Length)];
            }

            //for debugging
            //Output.Text = word;

            //reset crap
            charList.Clear();
            wrongGuesses = 0;
            UpdatePic(0);

            //enable all ze buttons
            this.KeyPreview = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;

            //lenght of the word with spaces
            int dubs = word.Length * 2;

            disp = new char[(word.Length*2)];
            oldDisp = new char[(word.Length*2)];

            //init disp array with spaces
            for (i = 0; i < (word.Length*2); i += 2)
            {
                disp[i] = '_';
                disp[i + 1] = ' ';
                oldDisp[i] = '_';
                oldDisp[i + 1] = ' ';
            }

            //word seperated into chars
            wordChar = new char[(word.Length * 2)];
            for (i = 0; i < word.Length; i++)
            {
                wordChar[i] = word[i];
            }

            //add chars to the list
            for (i = 0; i < wordChar.Length; i++)
            {
                charList.Add(wordChar[i]);
            }

            //insert blanks after each letter
            for (i = 1; i < dubs; i += 2)
            {
                charList.Insert(i, ' ');
            }
            
            lblDisplay.Text = "";
            displayString = "";

            //show the original display
            for (i = 0; i < disp.Length; i++)
            {
                displayString = displayString + char.ToString(disp[i]);
            }

            lblDisplay.Text = displayString;
        }

        //where most of the business happens
        public void CheckLetter(char g)
        {
            for (i = 0; i < disp.Length;)
            {
                if (g == charList[i])
                {
                    disp[i] = g;
                }
                
                i += 2;
            }

            //check if it was wrong
            //by comparing to previous string
            if (new string(oldDisp) == new string(disp))
            {
                wrongGuesses++;
            }

            for (i = 0; i < disp.Length; i++)
            {
                oldDisp[i] = disp[i];
            }

            //update picture
            UpdatePic(wrongGuesses);

            //clear the display string and re-init
            displayString = "";
            for (i = 0; i < disp.Length; i++)
            {
                displayString = displayString + char.ToString(disp[i]);
            }

            lblDisplay.Text = displayString;

            //when they win
            if (!displayString.Contains("_"))
            {
                pic.Image = Hangman.Properties.Resources.h11;
                DisableButtons();
            }
        }

        //this controls the hangman picture, based off how many wrong guesses made
        public void UpdatePic(int wg)
        {
            if (radEasy.Checked)
            {
                switch (wg)
                {
                    case 0:
                        pic.Image = Hangman.Properties.Resources.h0;
                        break;
                    case 1:
                        pic.Image = Hangman.Properties.Resources.h1;
                        break;
                    case 2:
                        pic.Image = Hangman.Properties.Resources.h2;
                        break;
                    case 3:
                        pic.Image = Hangman.Properties.Resources.h3;
                        break;
                    case 4:
                        pic.Image = Hangman.Properties.Resources.h4;
                        break;
                    case 5:
                        pic.Image = Hangman.Properties.Resources.h5;
                        break;
                    case 6:
                        pic.Image = Hangman.Properties.Resources.h6;
                        break;
                    case 7:
                        pic.Image = Hangman.Properties.Resources.h7;
                        break;
                    case 8:
                        pic.Image = Hangman.Properties.Resources.h8;
                        break;
                    case 9:
                        pic.Image = Hangman.Properties.Resources.h9;
                        break;
                    case 10:
                        pic.Image = Hangman.Properties.Resources.h9_1;
                        break;
                    case 11:
                        pic.Image = Hangman.Properties.Resources.h9_2;
                        break;
                    case 12:
                        pic.Image = Hangman.Properties.Resources.h9_3;
                        break;
                    case 13:
                        pic.Image = Hangman.Properties.Resources.h9_4;
                        break;
                    case 14:
                        pic.Image = Hangman.Properties.Resources.h9_5;
                        break;
                    case 15:
                        pic.Image = Hangman.Properties.Resources.h9_6;
                        break;
                    default: //lost
                        pic.Image = Hangman.Properties.Resources.h9_7;
                        DisableButtons();
                        break;
                }
            }
            else if (radMedium.Checked)
            {
                switch (wg)
                {
                    case 0:
                        pic.Image = Hangman.Properties.Resources.h0;
                        break;
                    case 1:
                        pic.Image = Hangman.Properties.Resources.h1;
                        break;
                    case 2:
                        pic.Image = Hangman.Properties.Resources.h2;
                        break;
                    case 3:
                        pic.Image = Hangman.Properties.Resources.h3;
                        break;
                    case 4:
                        pic.Image = Hangman.Properties.Resources.h4;
                        break;
                    case 5:
                        pic.Image = Hangman.Properties.Resources.h5;
                        break;
                    case 6:
                        pic.Image = Hangman.Properties.Resources.h6;
                        break;
                    case 7:
                        pic.Image = Hangman.Properties.Resources.h7;
                        break;
                    case 8:
                        pic.Image = Hangman.Properties.Resources.h8;
                        break;
                    case 9:
                        pic.Image = Hangman.Properties.Resources.h9;
                        break;
                    default: //lost
                        pic.Image = Hangman.Properties.Resources.h10;
                        DisableButtons();
                        break;
                }
            }
            else //hard
            {
                switch (wg)
                {
                    case 0:
                        pic.Image = Hangman.Properties.Resources.h0;
                        break;
                    case 1:
                        pic.Image = Hangman.Properties.Resources.h1;
                        break;
                    case 2:
                        pic.Image = Hangman.Properties.Resources.h2;
                        break;
                    case 3:
                        pic.Image = Hangman.Properties.Resources.h4;
                        break;
                    case 4:
                        pic.Image = Hangman.Properties.Resources.h6;
                        break;
                    case 5:
                        pic.Image = Hangman.Properties.Resources.h8;
                        break;
                    case 6:
                        pic.Image = Hangman.Properties.Resources.h9;
                        break;
                    default: //lost
                        pic.Image = Hangman.Properties.Resources.h10;
                        DisableButtons();
                        break;
                }
            }
        }

        //each time a button is pressed, the char is passed
        //to the checkletter method
        private void btnA_Click(object sender, EventArgs e)
        {
            guess = 'a';
            CheckLetter(guess);
            btnA.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            guess = 'b';
            CheckLetter(guess);
            btnB.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            guess = 'c';
            CheckLetter(guess);
            btnC.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            guess = 'd';
            CheckLetter(guess);
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            guess = 'e';
            CheckLetter(guess);
            btnE.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            guess = 'f';
            CheckLetter(guess);
            btnF.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            guess = 'g';
            CheckLetter(guess);
            btnG.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            guess = 'h';
            CheckLetter(guess);
            btnH.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            guess = 'i';
            CheckLetter(guess);
            btnI.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            guess = 'j';
            CheckLetter(guess);
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            guess = 'k';
            CheckLetter(guess);
            btnK.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            guess = 'l';
            CheckLetter(guess);
            btnL.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            guess = 'm';
            CheckLetter(guess);
            btnM.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            guess = 'n';
            CheckLetter(guess);
            btnN.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            guess = 'o';
            CheckLetter(guess);
            btnO.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            guess = 'p';
            CheckLetter(guess);
            btnP.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            guess = 'q';
            CheckLetter(guess);
            btnQ.Enabled = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            guess = 'r';
            CheckLetter(guess);
            btnR.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            guess = 's';
            CheckLetter(guess);
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            guess = 't';
            CheckLetter(guess);
            btnT.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            guess = 'u';
            CheckLetter(guess);
            btnU.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            guess = 'v';
            CheckLetter(guess);
            btnV.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            guess = 'w';
            CheckLetter(guess);
            btnW.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            guess = 'x';
            CheckLetter(guess);
            btnX.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            guess = 'y';
            CheckLetter(guess);
            btnY.Enabled = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            guess = 'z';
            CheckLetter(guess);
            btnZ.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (btnA.Enabled)
                    {
                        btnA_Click(obj, ea);
                    }
                    break;
                case Keys.B:
                    if (btnB.Enabled)
                    {
                        btnB_Click(obj, ea); 
                    }
                    break;
                case Keys.C:
                    if (btnC.Enabled)
                    {
                        btnC_Click(obj, ea); 
                    }
                    break;
                case Keys.D:
                    if (btnD.Enabled)
                    {
                        btnD_Click(obj, ea); 
                    }
                    break;
                case Keys.E:
                    if (btnE.Enabled)
                    {
                        btnE_Click(obj, ea); 
                    }
                    break;
                case Keys.F:
                    if (btnF.Enabled)
                    {
                        btnF_Click(obj, ea); 
                    }
                    break;
                case Keys.G:
                    if (btnG.Enabled)
                    {
                        btnG_Click(obj, ea); 
                    }
                    break;
                case Keys.H:
                    if (btnH.Enabled)
                    {
                        btnH_Click(obj, ea); 
                    }
                    break;
                case Keys.I:
                    if (btnI.Enabled)
                    {
                        btnI_Click(obj, ea); 
                    }
                    break;
                case Keys.J:
                    if (btnJ.Enabled)
                    {
                        btnJ_Click(obj, ea); 
                    }
                    break;
                case Keys.K:
                    if (btnK.Enabled)
                    {
                        btnK_Click(obj, ea); 
                    }
                    break;
                case Keys.L:
                    if (btnL.Enabled)
                    {
                        btnL_Click(obj, ea); 
                    }
                    break;
                case Keys.M:
                    if (btnM.Enabled)
                    {
                        btnM_Click(obj, ea); 
                    }
                    break;
                case Keys.N:
                    if (btnN.Enabled)
                    {
                        btnN_Click(obj, ea); 
                    }
                    break;
                case Keys.O:
                    if (btnO.Enabled)
                    {
                        btnO_Click(obj, ea); 
                    }
                    break;
                case Keys.P:
                    if (btnP.Enabled)
                    {
                        btnP_Click(obj, ea); 
                    }
                    break;
                case Keys.Q:
                    if (btnQ.Enabled)
                    {
                        btnQ_Click(obj, ea); 
                    }
                    break;
                case Keys.R:
                    if (btnR.Enabled)
                    {
                        btnR_Click(obj, ea); 
                    }
                    break;
                case Keys.S:
                    if (btnS.Enabled)
                    {
                        btnS_Click(obj, ea); 
                    }
                    break;
                case Keys.T:
                    if (btnT.Enabled)
                    {
                        btnT_Click(obj, ea); 
                    }
                    break;
                case Keys.U:
                    if (btnU.Enabled)
                    {
                        btnU_Click(obj, ea); 
                    }
                    break;
                case Keys.V:
                    if (btnV.Enabled)
                    {
                        btnV_Click(obj, ea); 
                    }
                    break;
                case Keys.W:
                    if (btnW.Enabled)
                    {
                        btnW_Click(obj, ea); 
                    }
                    break;
                case Keys.X:
                    if (btnX.Enabled)
                    {
                        btnX_Click(obj, ea); 
                    }
                    break;
                case Keys.Y:
                    if (btnY.Enabled)
                    {
                        btnY_Click(obj, ea); 
                    }
                    break;
                case Keys.Z:
                    if (btnZ.Enabled)
                    {
                        btnZ_Click(obj, ea); 
                    }
                    break;
                case Keys.RShiftKey:
                    btnNewGame_Click(obj, ea);
                    break;
            } 
        }
    }
}

