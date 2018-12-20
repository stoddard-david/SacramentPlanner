using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SacramentPlanner.Models
{
  public enum Song
  {
    [Display(Name = "1 - The Morning Breaks")]
    Hymn001,
    [Display(Name = "2 - The Spirit of God")]
    Hymn002,
    [Display(Name = "3 - Now Let Us Rejoice")]
    Hymn003,
    [Display(Name = "4 - Truth Eternal")]
    Hymn004,
    [Display(Name = "5 - High on the Mountain Top")]
    Hymn005,
    [Display(Name = "6 - Redeemer of Israel")]
    Hymn006,
    [Display(Name = "7 - Israel, Israel, God Is Calling")]
    Hymn007,
    [Display(Name = "8 - Awake and Arise")]
    Hymn008,
    [Display(Name = "9 - Come, Rejoice")]
    Hymn009,
    [Display(Name = "10 - Come, Sing to the Lord")]
    Hymn010,
    [Display(Name = "11 - What Was Witnessed in the Heavens?")]
    Hymn011,
    [Display(Name = "12 - ’Twas Witnessed in the Morning Sky")]
    Hymn012,
    [Display(Name = "13 - An Angel from on High")]
    Hymn013,
    [Display(Name = "14 - Sweet Is the Peace the Gospel Brings")]
    Hymn014,
    [Display(Name = "15 - I Saw a Mighty Angel Fly")]
    Hymn015,
    [Display(Name = "16 - What Glorious Scenes Mine Eyes Behold")]
    Hymn016,
    [Display(Name = "17 - Awake, Ye Saints of God, Awake!")]
    Hymn017,
    [Display(Name = "18 - The Voice of God Again Is Heard")]
    Hymn018,
    [Display(Name = "19 - We Thank Thee, O God, for a Prophet")]
    Hymn019,
    [Display(Name = "20 - God of Power, God of Right")]
    Hymn020,
    [Display(Name = "21 - Come, Listen to a Prophet’s Voice")]
    Hymn021,
    [Display(Name = "22 - We Listen to a Prophet’s Voice")]
    Hymn022,
    [Display(Name = "23 - We Ever Pray for Thee")]
    Hymn023,
    [Display(Name = "24 - God Bless Our Prophet Dear")]
    Hymn024,
    [Display(Name = "25 - Now We’ll Sing with One Accord")]
    Hymn025,
    [Display(Name = "26 - Joseph Smith’s First Prayer")]
    Hymn026,
    [Display(Name = "27 - Praise to the Man")]
    Hymn027,
    [Display(Name = "28 - Saints, Behold How Great Jehovah")]
    Hymn028,
    [Display(Name = "29 - A Poor Wayfaring Man of Grief")]
    Hymn029,
    [Display(Name = "30 - Come, Come, Ye Saints")]
    Hymn030,
    [Display(Name = "31 - O God, Our Help in Ages Past")]
    Hymn031,
    [Display(Name = "32 - The Happy Day at Last Has Come")]
    Hymn032,
    [Display(Name = "33 - Our Mountain Home So Dear")]
    Hymn033,
    [Display(Name = "34 - O Ye Mountains High")]
    Hymn034,
    [Display(Name = "35 - For the Strength of the Hills")]
    Hymn035,
    [Display(Name = "36 - They, the Builders of the Nation")]
    Hymn036,
    [Display(Name = "37 - The Wintry Day, Descending to Its Close")]
    Hymn037,
    [Display(Name = "38 - Come, All Ye Saints of Zion")]
    Hymn038,
    [Display(Name = "39 - O Saints of Zion")]
    Hymn039,
    [Display(Name = "40 - Arise, O Glorious Zion")]
    Hymn040,
    [Display(Name = "41 - Let Zion in Her Beauty Rise")]
    Hymn041,
    [Display(Name = "42 - Hail to the Brightness of Zion's Glad Morning!")]
    Hymn042,
    [Display(Name = "43 - Zion Stands with Hills Surrounded")]
    Hymn043,
    [Display(Name = "44 - Beautiful Zion, Built Above")]
    Hymn044,
    [Display(Name = "45 - Lead Me into Life Eternal")]
    Hymn045,
    [Display(Name = "46 - Glorious Things of Thee Are Spoken")]
    Hymn046,
    [Display(Name = "47 - We Will Sing of Zion")]
    Hymn047,
    [Display(Name = "48 - Glorious Things Are Sung of Zion")]
    Hymn048,
    [Display(Name = "49 - Adam-ondi-Ahman")]
    Hymn049,
    [Display(Name = "50 - Come, Thou Glorious Day of Promise")]
    Hymn050,
    [Display(Name = "51 - Sons of Michael, He Approaches")]
    Hymn051,
    [Display(Name = "52 - The Day Dawn Is Breaking")]
    Hymn052,
    [Display(Name = "53 - Let Earth's Inhabitants Rejoice")]
    Hymn053,
    [Display(Name = "54 - Behold, the Mountain of the Lord")]
    Hymn054,
    [Display(Name = "55 - Lo, the Mighty God Appearing!")]
    Hymn055,
    [Display(Name = "56 - Softly Beams the Sacred Dawning")]
    Hymn056,
    [Display(Name = "57 - We’re Not Ashamed to Own Our Lord")]
    Hymn057,
    [Display(Name = "58 - Come, Ye Children of the Lord")]
    Hymn058,
    [Display(Name = "59 - Come, O Thou King of Kings")]
    Hymn059,
    [Display(Name = "60 - Battle Hymn of the Republic")]
    Hymn060,
    [Display(Name = "61 - Raise Your Voices to the Lord")]
    Hymn061,
    [Display(Name = "62 - All Creatures of Our God and King")]
    Hymn062,
    [Display(Name = "63 - Great King of Heaven")]
    Hymn063,
    [Display(Name = "64 - On This Day of Joy and Gladness")]
    Hymn064,
    [Display(Name = "65 - Come, All Ye Saints Who Dwell on Earth")]
    Hymn065,
    [Display(Name = "66 - Rejoice, the Lord Is King!")]
    Hymn066,
    [Display(Name = "67 - Glory to God on High")]
    Hymn067,
    [Display(Name = "68 - A Mighty Fortress Is Our God")]
    Hymn068,
    [Display(Name = "69 - All Glory, Laud, and Honor")]
    Hymn069,
    [Display(Name = "70 - Sing Praise to Him")]
    Hymn070,
    [Display(Name = "71 - With Songs of Praise")]
    Hymn071,
    [Display(Name = "72 - Praise to the Lord, the Almighty")]
    Hymn072,
    [Display(Name = "73 - Praise the Lord with Heart and Voice")]
    Hymn073,
    [Display(Name = "74 - Praise Ye the Lord")]
    Hymn074,
    [Display(Name = "75 - In Hymns of Praise")]
    Hymn075,
    [Display(Name = "76 - God of Our Fathers, We Come unto Thee")]
    Hymn076,
    [Display(Name = "77 - Great Is the Lord")]
    Hymn077,
    [Display(Name = "78 - God of Our Fathers, Whose Almighty Hand")]
    Hymn078,
    [Display(Name = "79 - With All the Power of Heart and Tongue")]
    Hymn079,
    [Display(Name = "80 - God of Our Fathers, Known of Old")]
    Hymn080,
    [Display(Name = "81 - Press Forward, Saints")]
    Hymn081,
    [Display(Name = "82 - For All the Saints")]
    Hymn082,
    [Display(Name = "83 - Guide Us, O Thou Great Jehovah")]
    Hymn083,
    [Display(Name = "84 - Faith of Our Fathers")]
    Hymn084,
    [Display(Name = "85 - How Firm a Foundation")]
    Hymn085,
    [Display(Name = "86 - How Great Thou Art")]
    Hymn086,
    [Display(Name = "87 - God Is Love")]
    Hymn087,
    [Display(Name = "88 - Great God, Attend While Zion Sings")]
    Hymn088,
    [Display(Name = "89 - The Lord Is My Light")]
    Hymn089,
    [Display(Name = "90 - From All That Dwell below the Skies")]
    Hymn090,
    [Display(Name = "91 - Father, Thy Children to Thee Now Raise")]
    Hymn091,
    [Display(Name = "92 - For the Beauty of the Earth")]
    Hymn092,
    [Display(Name = "93 - Prayer of Thanksgiving")]
    Hymn093,
    [Display(Name = "94 - Come, Ye Thankful People")]
    Hymn094,
    [Display(Name = "95 - Now Thank We All Our God")]
    Hymn095,
    [Display(Name = "96 - Dearest Children, God Is Near You")]
    Hymn096,
    [Display(Name = "97 - Lead, Kindly Light")]
    Hymn097,
    [Display(Name = "98 - I Need Thee Every Hour")]
    Hymn098,
    [Display(Name = "99 - Nearer, Dear Savior, to Thee")]
    Hymn099,
    [Display(Name = "100 - Nearer, My God, to Thee")]
    Hymn100,
    [Display(Name = "101 - Guide Me to Thee")]
    Hymn101,
    [Display(Name = "102 - Jesus, Lover of My Soul")]
    Hymn102,
    [Display(Name = "103 - Precious Savior, Dear Redeemer")]
    Hymn103,
    [Display(Name = "104 - Jesus, Savior, Pilot Me")]
    Hymn104,
    [Display(Name = "105 - Master, the Tempest Is Raging")]
    Hymn105,
    [Display(Name = "106 - God Speed the Right")]
    Hymn106,
    [Display(Name = "107 - Lord, Accept Our True Devotion")]
    Hymn107,
    [Display(Name = "108 - The Lord Is My Shepherd")]
    Hymn108,
    [Display(Name = "109 - The Lord My Pasture Will Prepare")]
    Hymn109,
    [Display(Name = "110 - Cast Thy Burden upon the Lord")]
    Hymn110,
    [Display(Name = "111 - Rock of Ages")]
    Hymn111,
    [Display(Name = "112 - Savior, Redeemer of My Soul")]
    Hymn112,
    [Display(Name = "113 - Our Savior's Love")]
    Hymn113,
    [Display(Name = "114 - Come unto Him")]
    Hymn114,
    [Display(Name = "115 - Come, Ye Disconsolate")]
    Hymn115,
    [Display(Name = "116 - Come, Follow Me")]
    Hymn116,
    [Display(Name = "117 - Come unto Jesus")]
    Hymn117,
    [Display(Name = "118 - Ye Simple Souls Who Stray")]
    Hymn118,
    [Display(Name = "119 - Come, We That Love the Lord")]
    Hymn119,
    [Display(Name = "120 - Lean on My Ample Arm")]
    Hymn120,
    [Display(Name = "121 - I’m a Pilgrim, I’m a Stranger")]
    Hymn121,
    [Display(Name = "122 - Though Deepening Trials")]
    Hymn122,
    [Display(Name = "123 - Oh, May My Soul Commune with Thee")]
    Hymn123,
    [Display(Name = "124 - Be Still, My Soul")]
    Hymn124,
    [Display(Name = "125 - How Gentle God's Commands")]
    Hymn125,
    [Display(Name = "126 - How Long, O Lord Most Holy and True")]
    Hymn126,
    [Display(Name = "127 - Does the Journey Seem Long?")]
    Hymn127,
    [Display(Name = "128 - When Faith Endures")]
    Hymn128,
    [Display(Name = "129 - Where Can I Turn for Peace?")]
    Hymn129,
    [Display(Name = "130 - Be Thou Humble")]
    Hymn130,
    [Display(Name = "131 - More Holiness Give Me")]
    Hymn131,
    [Display(Name = "132 - God Is in His Holy Temple")]
    Hymn132,
    [Display(Name = "133 - Father in Heaven")]
    Hymn133,
    [Display(Name = "134 - I Believe in Christ")]
    Hymn134,
    [Display(Name = "135 - My Redeemer Lives")]
    Hymn135,
    [Display(Name = "136 - I Know That My Redeemer Lives")]
    Hymn136,
    [Display(Name = "137 - Testimony")]
    Hymn137,
    [Display(Name = "138 - Bless Our Fast, We Pray")]
    Hymn138,
    [Display(Name = "139 - In Fasting We Approach Thee")]
    Hymn139,
    [Display(Name = "140 - Did You Think to Pray?")]
    Hymn140,
    [Display(Name = "141 - Jesus, the Very Thought of Thee")]
    Hymn141,
    [Display(Name = "142 - Sweet Hour of Prayer")]
    Hymn142,
    [Display(Name = "143 - Let the Holy Spirit Guide")]
    Hymn143,
    [Display(Name = "144 - Secret Prayer")]
    Hymn144,
    [Display(Name = "145 - Prayer Is the Soul's Sincere Desire")]
    Hymn145,
    [Display(Name = "146 - Gently Raise the Sacred Strain")]
    Hymn146,
    [Display(Name = "147 - Sweet Is the Work")]
    Hymn147,
    [Display(Name = "148 - Sabbath Day")]
    Hymn148,
    [Display(Name = "149 - As the Dew from Heaven Distilling")]
    Hymn149,
    [Display(Name = "150 - O Thou Kind and Gracious Father")]
    Hymn150,
    [Display(Name = "151 - We Meet, Dear Lord")]
    Hymn151,
    [Display(Name = "152 - God Be with You Till We Meet Again")]
    Hymn152,
    [Display(Name = "153 - Lord, We Ask Thee Ere We Part")]
    Hymn153,
    [Display(Name = "154 - Father, This Hour Has Been One of Joy")]
    Hymn154,
    [Display(Name = "155 - We Have Partaken of Thy Love")]
    Hymn155,
    [Display(Name = "156 - Sing We Now at Parting")]
    Hymn156,
    [Display(Name = "157 - Thy Spirit, Lord, Has Stirred Our Souls")]
    Hymn157,
    [Display(Name = "158 - Before Thee, Lord, I Bow My Head")]
    Hymn158,
    [Display(Name = "159 - Now the Day Is Over")]
    Hymn159,
    [Display(Name = "160 - Softly Now the Light of Day")]
    Hymn160,
    [Display(Name = "161 - The Lord Be with Us")]
    Hymn161,
    [Display(Name = "162 - Lord, We Come before Thee Now")]
    Hymn162,
    [Display(Name = "163 - Lord, Dismiss Us with Thy Blessing")]
    Hymn163,
    [Display(Name = "164 - Great God, to Thee My Evening Song")]
    Hymn164,
    [Display(Name = "165 - Abide with Me; 'Tis Eventide")]
    Hymn165,
    [Display(Name = "166 - Abide with Me!")]
    Hymn166,
    [Display(Name = "167 - Come, Let Us Sing an Evening Hymn")]
    Hymn167,
    [Display(Name = "168 - As the Shadows Fall")]
    Hymn168,
    [Display(Name = "169 - As Now We Take the Sacrament")]
    Hymn169,
    [Display(Name = "170 - God, Our Father, Hear Us Pray")]
    Hymn170,
    [Display(Name = "171 - With Humble Heart")]
    Hymn171,
    [Display(Name = "172 - In Humility, Our Savior")]
    Hymn172,
    [Display(Name = "173 - While of These Emblems We Partake")]
    Hymn173,
    [Display(Name = "174 - While of These Emblems We Partake")]
    Hymn174,
    [Display(Name = "175 - O God, the Eternal Father")]
    Hymn175,
    [Display(Name = "176 - 'Tis Sweet to Sing the Matchless Love")]
    Hymn176,
    [Display(Name = "177 - 'Tis Sweet To Sing the Matchless Love")]
    Hymn177,
    [Display(Name = "178 - O Lord of Hosts")]
    Hymn178,
    [Display(Name = "179 - Again, Our Dear Redeeming Lord")]
    Hymn179,
    [Display(Name = "180 - Father in Heaven, We Do Believe")]
    Hymn180,
    [Display(Name = "181 - Jesus of Nazareth, Savior and King")]
    Hymn181,
    [Display(Name = "182 - We’ll Sing All Hail to Jesus’ Name")]
    Hymn182,
    [Display(Name = "183 - In Remembrance of Thy Suffering")]
    Hymn183,
    [Display(Name = "184 - Upon the Cross of Calvary")]
    Hymn184,
    [Display(Name = "185 - Reverently and Meekly Now")]
    Hymn185,
    [Display(Name = "186 - Again We Meet around the Board")]
    Hymn186,
    [Display(Name = "187 - God Loved Us, So He Sent His Son")]
    Hymn187,
    [Display(Name = "188 - Thy Will, O Lord, Be Done")]
    Hymn188,
    [Display(Name = "189 - O Thou, Before the World Began")]
    Hymn189,
    [Display(Name = "190 - In Memory of the Crucified")]
    Hymn190,
    [Display(Name = "191 - Behold the Great Redeemer Die")]
    Hymn191,
    [Display(Name = "192 - He Died! The Great Redeemer Died")]
    Hymn192,
    [Display(Name = "193 - I Stand All Amazed")]
    Hymn193,
    [Display(Name = "194 - There Is a Green Hill Far Away")]
    Hymn194,
    [Display(Name = "195 - How Great the Wisdom and the Love")]
    Hymn195,
    [Display(Name = "196 - Jesus, Once of Humble Birth")]
    Hymn196,
    [Display(Name = "197 - O Savior, Thou Who Wearest a Crown")]
    Hymn197,
    [Display(Name = "198 - That Easter Morn")]
    Hymn198,
    [Display(Name = "199 - He Is Risen!")]
    Hymn199,
    [Display(Name = "200 - Christ the Lord Is Risen Today")]
    Hymn200,
    [Display(Name = "201 - Joy to the World")]
    Hymn201,
    [Display(Name = "202 - Oh, Come, All Ye Faithful")]
    Hymn202,
    [Display(Name = "203 - Angels We Have Heard on High")]
    Hymn203,
    [Display(Name = "204 - Silent Night")]
    Hymn204,
    [Display(Name = "205 - Once in Royal David’s City")]
    Hymn205,
    [Display(Name = "206 - Away in a Manger")]
    Hymn206,
    [Display(Name = "207 - It Came upon the Midnight Clear")]
    Hymn207,
    [Display(Name = "208 - O Little Town of Bethlehem")]
    Hymn208,
    [Display(Name = "209 - Hark! The Herald Angels Sing")]
    Hymn209,
    [Display(Name = "210 - With Wondering Awe")]
    Hymn210,
    [Display(Name = "211 - While Shepherds Watched Their Flocks")]
    Hymn211,
    [Display(Name = "212 - Far, Far Away on Judea’s Plains")]
    Hymn212,
    [Display(Name = "213 - The First Noel")]
    Hymn213,
    [Display(Name = "214 - I Heard the Bells on Christmas Day")]
    Hymn214,
    [Display(Name = "215 - Ring Out, Wild Bells")]
    Hymn215,
    [Display(Name = "216 - We Are Sowing")]
    Hymn216,
    [Display(Name = "217 - Come, Let Us Anew")]
    Hymn217,
    [Display(Name = "218 - We Give Thee But Thine Own")]
    Hymn218,
    [Display(Name = "219 - Because I Have Been Given Much")]
    Hymn219,
    [Display(Name = "220 - Lord, I Would Follow Thee")]
    Hymn220,
    [Display(Name = "221 - Dear to the Heart of the Shepherd")]
    Hymn221,
    [Display(Name = "222 - Hear Thou Our Hymn, O Lord")]
    Hymn222,
    [Display(Name = "223 - Have I Done Any Good?")]
    Hymn223,
    [Display(Name = "224 - I Have Work Enough to Do")]
    Hymn224,
    [Display(Name = "225 - We Are Marching On to Glory")]
    Hymn225,
    [Display(Name = "226 - Improve the Shining Moments")]
    Hymn226,
    [Display(Name = "227 - There Is Sunshine in My Soul Today")]
    Hymn227,
    [Display(Name = "228 - You Can Make the Pathway Bright")]
    Hymn228,
    [Display(Name = "229 - Today, While the Sun Shines")]
    Hymn229,
    [Display(Name = "230 - Scatter Sunshine")]
    Hymn230,
    [Display(Name = "231 - Father, Cheer Our Souls Tonight")]
    Hymn231,
    [Display(Name = "232 - Let Us Oft Speak Kind Words")]
    Hymn232,
    [Display(Name = "233 - Nay, Speak No Ill")]
    Hymn233,
    [Display(Name = "234 - Jesus, Mighty King in Zion")]
    Hymn234,
    [Display(Name = "235 - Should You Feel Inclined to Censure")]
    Hymn235,
    [Display(Name = "236 - Lord, Accept into Thy Kingdom")]
    Hymn236,
    [Display(Name = "237 - Do What Is Right")]
    Hymn237,
    [Display(Name = "238 - Behold Thy Sons and Daughters, Lord")]
    Hymn238,
    [Display(Name = "239 - Choose the Right")]
    Hymn239,
    [Display(Name = "240 - Know This, That Every Soul Is Free")]
    Hymn240,
    [Display(Name = "241 - Count Your Blessings")]
    Hymn241,
    [Display(Name = "242 - Praise God, from Whom All Blessings Flow")]
    Hymn242,
    [Display(Name = "243 - Let Us All Press On")]
    Hymn243,
    [Display(Name = "244 - Come Along, Come Along")]
    Hymn244,
    [Display(Name = "245 - This House We Dedicate to Thee")]
    Hymn245,
    [Display(Name = "246 - Onward, Christian Soldiers")]
    Hymn246,
    [Display(Name = "247 - We Love Thy House, O God")]
    Hymn247,
    [Display(Name = "248 - Up, Awake, Ye Defenders of Zion")]
    Hymn248,
    [Display(Name = "249 - Called to Serve")]
    Hymn249,
    [Display(Name = "250 - We Are All Enlisted")]
    Hymn250,
    [Display(Name = "251 - Behold! A Royal Army")]
    Hymn251,
    [Display(Name = "252 - Put Your Shoulder to the Wheel")]
    Hymn252,
    [Display(Name = "253 - Like Ten Thousand Legions Marching")]
    Hymn253,
    [Display(Name = "254 - True to the Faith")]
    Hymn254,
    [Display(Name = "255 - Carry On")]
    Hymn255,
    [Display(Name = "256 - As Zion’s Youth in Latter Days")]
    Hymn256,
    [Display(Name = "257 - Rejoice! A Glorious Sound Is Heard")]
    Hymn257,
    [Display(Name = "258 - O Thou Rock of Our Salvation")]
    Hymn258,
    [Display(Name = "259 - Hope of Israel")]
    Hymn259,
    [Display(Name = "260 - Who’s on the Lord’s Side?")]
    Hymn260,
    [Display(Name = "261 - Thy Servants Are Prepared")]
    Hymn261,
    [Display(Name = "262 - Go, Ye Messengers of Glory")]
    Hymn262,
    [Display(Name = "263 - Go Forth with Faith")]
    Hymn263,
    [Display(Name = "264 - Hark, All Ye Nations!")]
    Hymn264,
    [Display(Name = "265 - Arise, O God, and Shine")]
    Hymn265,
    [Display(Name = "266 - The Time Is Far Spent")]
    Hymn266,
    [Display(Name = "267 - How Wondrous and Great")]
    Hymn267,
    [Display(Name = "268 - Come, All Whose Souls Are Lighted")]
    Hymn268,
    [Display(Name = "269 - Jehovah, Lord of Heaven and Earth")]
    Hymn269,
    [Display(Name = "270 - I’ll Go Where You Want Me to Go")]
    Hymn270,
    [Display(Name = "271 - Oh, Holy Words of Truth and Love")]
    Hymn271,
    [Display(Name = "272 - Oh Say, What Is Truth?")]
    Hymn272,
    [Display(Name = "273 - Truth Reflects upon Our Senses")]
    Hymn273,
    [Display(Name = "274 - The Iron Rod")]
    Hymn274,
    [Display(Name = "275 - Men Are That They Might Have Joy")]
    Hymn275,
    [Display(Name = "276 - Come Away to the Sunday School")]
    Hymn276,
    [Display(Name = "277 - As I Search the Holy Scriptures")]
    Hymn277,
    [Display(Name = "278 - Thanks for the Sabbath School")]
    Hymn278,
    [Display(Name = "279 - Thy Holy Word")]
    Hymn279,
    [Display(Name = "280 - Welcome, Welcome, Sabbath Morning")]
    Hymn280,
    [Display(Name = "281 - Help Me Teach with Inspiration")]
    Hymn281,
    [Display(Name = "282 - We Meet Again in Sabbath School")]
    Hymn282,
    [Display(Name = "283 - The Glorious Gospel Light Has Shone")]
    Hymn283,
    [Display(Name = "284 - If You Could Hie to Kolob")]
    Hymn284,
    [Display(Name = "285 - God Moves in a Mysterious Way")]
    Hymn285,
    [Display(Name = "286 - Oh, What Songs of the Heart")]
    Hymn286,
    [Display(Name = "287 - Rise, Ye Saints, and Temples Enter")]
    Hymn287,
    [Display(Name = "288 - How Beautiful Thy Temples, Lord")]
    Hymn288,
    [Display(Name = "289 - Holy Temples on Mount Zion")]
    Hymn289,
    [Display(Name = "290 - Rejoice, Ye Saints of Latter Days")]
    Hymn290,
    [Display(Name = "291 - Turn Your Hearts")]
    Hymn291,
    [Display(Name = "292 - O My Father")]
    Hymn292,
    [Display(Name = "293 - Each Life That Touches Ours for Good")]
    Hymn293,
    [Display(Name = "294 - Love at Home")]
    Hymn294,
    [Display(Name = "295 - O Love That Glorifies the Son")]
    Hymn295,
    [Display(Name = "296 - Our Father, by Whose Name")]
    Hymn296,
    [Display(Name = "297 - From Homes of Saints Glad Songs Arise")]
    Hymn297,
    [Display(Name = "298 - Home Can Be a Heaven on Earth")]
    Hymn298,
    [Display(Name = "299 - Children of Our Heavenly Father")]
    Hymn299,
    [Display(Name = "300 - Families Can Be Together Forever")]
    Hymn300,
    [Display(Name = "301 - I Am a Child of God")]
    Hymn301,
    [Display(Name = "302 - I Know My Father Lives")]
    Hymn302,
    [Display(Name = "303 - Keep the Commandments")]
    Hymn303,
    [Display(Name = "304 - Teach Me to Walk in the Light")]
    Hymn304,
    [Display(Name = "305 - The Light Divine")]
    Hymn305,
    [Display(Name = "306 - God's Daily Care")]
    Hymn306,
    [Display(Name = "307 - In Our Lovely Deseret")]
    Hymn307,
    [Display(Name = "308 - Love One Another")]
    Hymn308,
    [Display(Name = "309 - As Sisters in Zion")]
    Hymn309,
    [Display(Name = "310 - A Key Was Turned in Latter Days")]
    Hymn310,
    [Display(Name = "311 - We Meet Again as Sisters")]
    Hymn311,
    [Display(Name = "312 - We Ever Pray for Thee")]
    Hymn312,
    [Display(Name = "313 - God Is Love")]
    Hymn313,
    [Display(Name = "314 - How Gentle God’s Commands")]
    Hymn314,
    [Display(Name = "315 - Jesus, the Very Thought of Thee")]
    Hymn315,
    [Display(Name = "316 - The Lord Is My Shepherd")]
    Hymn316,
    [Display(Name = "317 - Sweet Is the Work")]
    Hymn317,
    [Display(Name = "318 - Love at Home")]
    Hymn318,
    [Display(Name = "319 - Ye Elders of Israel")]
    Hymn319,
    [Display(Name = "320 - The Priesthood of Our Lord")]
    Hymn320,
    [Display(Name = "321 - Ye Who Are Called to Labor")]
    Hymn321,
    [Display(Name = "322 - Come, All Ye Sons of God")]
    Hymn322,
    [Display(Name = "323 - Rise Up, O Men of God")]
    Hymn323,
    [Display(Name = "324 - Rise Up, O Men of God")]
    Hymn324,
    [Display(Name = "325 - See the Mighty Priesthood Gathered")]
    Hymn325,
    [Display(Name = "326 - Come, Come, Ye Saints")]
    Hymn326,
    [Display(Name = "327 - Go, Ye Messengers of Heaven")]
    Hymn327,
    [Display(Name = "328 - An Angel from on High")]
    Hymn328,
    [Display(Name = "329 - Thy Servants Are Prepared")]
    Hymn329,
    [Display(Name = "330 - See, the Mighty Angel Flying")]
    Hymn330,
    [Display(Name = "331 - Oh Say, What Is Truth?")]
    Hymn331,
    [Display(Name = "332 - Come, O Thou King of Kings")]
    Hymn332,
    [Display(Name = "333 - High on the Mountain Top")]
    Hymn333,
    [Display(Name = "334 - I Need Thee Every Hour")]
    Hymn334,
    [Display(Name = "335 - Brightly Beams Our Father’s Mercy")]
    Hymn335,
    [Display(Name = "336 - School Thy Feelings")]
    Hymn336,
    [Display(Name = "337 - O Home Beloved")]
    Hymn337,
    [Display(Name = "338 - America the Beautiful")]
    Hymn338,
    [Display(Name = "339 - My Country, 'Tis of Thee")]
    Hymn339,
    [Display(Name = "340 - The Star-Spangled Banner")]
    Hymn340,
    [Display(Name = "341 - God Save the King")]
    Hymn341
  }

    public enum Bishopric
    {
        [Display(Name = "Bishop Jones")]
        Bishop,
        [Display(Name = "Brother Smith")]
        FirstCounselor,
        [Display(Name = "Brother Green")]
        SecondCounselor
    }

    public class Meeting
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required]
        public Bishopric? Conducting { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public Song? OpeningHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Invocation { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public Song? SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public Song? ClosingHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Benediction { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }

    public static class Descriptions
    {
        public static List<Speaker> meetingSpeakers;

        public static IEnumerable<string> GetDescriptions(Type type)
        {
            var descs = new List<string>();
            var names = Enum.GetNames(type);
            foreach (var name in names)
            {
                var field = type.GetField(name);
                var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
                foreach (DescriptionAttribute fd in fds)
                {
                    descs.Add(fd.Description);
                }
            }
            return descs;
        }

    }
}
