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
    [Description("1 The Morning Breaks")]
    Hymn001 = 1,
    [Description("2 The Spirit of God")]
    Hymn002,
    [Description("3 Now Let Us Rejoice")]
    Hymn003,
    [Description("4 Truth Eternal")]
    Hymn004,
    [Description("5 High on the Mountain Top")]
    Hymn005,
    [Description("6 Redeemer of Israel")]
    Hymn006,
    [Description("7 Israel, Israel, God Is Calling")]
    Hymn007,
    [Description("8 Awake and Arise")]
    Hymn008,
    [Description("9 Come, Rejoice")]
    Hymn009,
    [Description("10 Come, Sing to the Lord")]
    Hymn010,
    [Description("11 What Was Witnessed in the Heavens?")]
    Hymn011,
    [Description("12 'Twas Witnessed in the Morning Sky")]
    Hymn012,
    [Description("13 An Angel from on High")]
    Hymn013,
    [Description("15 I Saw a Mighty Angel Fly")]
    Hymn015,
    [Description("16 What Glorious Scenes Mine Eyes Behold")]
    Hymn016,
    [Description("17 Awake, Ye Saints of God, Awake!")]
    Hymn017,
    [Description("18 The Voice of God Again Is Heard")]
    Hymn018,
    [Description("21 Come, Listen to a Prophet's Voice")]
    Hymn021,
    [Description("23 We Ever Pray for Thee")]
    Hymn023,
    [Description("24 God Bless Our Prophet Dear")]
    Hymn024,
    [Description("27 Praise to the Man")]
    Hymn027,
    [Description("29 A Poor Wayfaring Man of Grief")]
    Hymn029,
    [Description("30 Come, Come, Ye Saints")]
    Hymn030,
    [Description("33 Our Mountain Home So Dear")]
    Hymn033,
    [Description("34 O Ye Mountains High")]
    Hymn034,
    [Description("35 For the Strength of the Hills")]
    Hymn035,
    [Description("38 Come, All Ye Saints of Zion")]
    Hymn038,
    [Description("42 Hail to the Brightness of Zion's Glad Morning!")]
    Hymn042,
    [Description("43 Zion Stands with Hills Surrounded")]
    Hymn043,
    [Description("45 Lead Me into Life Eternal")]
    Hymn045,
    [Description("47 We Will Sing of Zion")]
    Hymn047,
    [Description("48 Glorious Things Are Sung of Zion")]
    Hymn048,
    [Description("57 We're Not Ashamed to Own Our Lord")]
    Hymn057,
    [Description("59 Come, O Thou King of Kings")]
    Hymn059,
    [Description("60 Battle Hymn of the Republic")]
    Hymn060,
    [Description("61 Raise Your Voices to the Lord")]
    Hymn061,
    [Description("62 All Creatures of Our God and King")]
    Hymn062,
    [Description("63 Great King of Heaven")]
    Hymn063,
    [Description("64 On This Day of Joy and Gladness")]
    Hymn064,
    [Description("65 Come, All Ye Saints Who Dwell on Earth")]
    Hymn065,
    [Description("67 Glory to God on High")]
    Hymn067,
    [Description("68 A Mighty Fortress Is Our God")]
    Hymn068,
    [Description("69 All Glory, Laud, and Honor")]
    Hymn069,
    [Description("72 Praise to the Lord, the Almighty")]
    Hymn072,
    [Description("73 Praise the Lord with Heart and Voice")]
    Hymn073,
    [Description("74 Praise Ye the Lord")]
    Hymn074,
    [Description("75 In Hymns of Praise")]
    Hymn075,
    [Description("77 Great Is the Lord")]
    Hymn077,
    [Description("80 God of Our Fathers, Known of Old")]
    Hymn080,
    [Description("81 Press Forward, Saints")]
    Hymn081,
    [Description("84 Faith of Our Fathers")]
    Hymn084,
    [Description("87 God Is Love")]
    Hymn087,
    [Description("89 The Lord Is My Light")]
    Hymn089,
    [Description("90 From All That Dwell below the Skies")]
    Hymn090,
    [Description("91 Father, Thy Children to Thee Now Raise")]
    Hymn091,
    [Description("94 Come, Ye Thankful People")]
    Hymn094,
    [Description("96 Dearest Children, God Is Near You")]
    Hymn096,
    [Description("97 Lead, Kindly Light")]
    Hymn097,
    [Description("98 I Need Thee Every Hour")]
    Hymn098,
    [Description("99 Nearer, Dear Savior, to Thee")]
    Hymn099,
    [Description("100 Nearer, My God, to Thee")]
    Hymn100,
    [Description("101 Guide Me to Thee")]
    Hymn101,
    [Description("103 Precious Savior, Dear Redeemer")]
    Hymn103,
    [Description("104 Jesus, Savior, Pilot Me")]
    Hymn104,
    [Description("108 The Lord Is My Shepherd")]
    Hymn108,
    [Description("110 Cast Thy Burden upon the Lord")]
    Hymn110,
    [Description("112 Savior, Redeemer of My Soul")]
    Hymn112,
    [Description("113 Our Savior's Love")]
    Hymn113,
    [Description("120 Lean on My Ample Arm")]
    Hymn120,
    [Description("121 I'm a Pilgrim, I'm a Stranger")]
    Hymn121,
    [Description("124 Be Still, My Soul")]
    Hymn124,
    [Description("126 How Long, O Lord Most Holy and True")]
    Hymn126,
    [Description("130 Be Thou Humble")]
    Hymn130,
    [Description("131 More Holiness Give Me")]
    Hymn131,
    [Description("132 God Is in His Holy Temple")]
    Hymn132,
    [Description("133 Father in Heaven")]
    Hymn133,
    [Description("135 My Redeemer Lives")]
    Hymn135,
    [Description("138 Bless Our Fast, We Pray")]
    Hymn138,
    [Description("141 Jesus, the Very Thought of Thee")]
    Hymn141,
    [Description("143 Let the Holy Spirit Guide")]
    Hymn143,
    [Description("144 Secret Prayer")]
    Hymn144,
    [Description("145 Prayer Is the Soul's Sincere Desire")]
    Hymn145,
    [Description("146 Gently Raise the Sacred Strain")]
    Hymn146,
    [Description("147 Sweet Is the Work")]
    Hymn147,
    [Description("149 As the Dew from Heaven Distilling")]
    Hymn149,
    [Description("150 O Thou Kind and Gracious Father")]
    Hymn150,
    [Description("154 Father, This Hour Has Been One of Joy")]
    Hymn154,
    [Description("155 We Have Partaken of Thy Love")]
    Hymn155,
    [Description("158 Before Thee, Lord, I Bow My Head")]
    Hymn158,
    [Description("159 Now the Day Is Over")]
    Hymn159,
    [Description("163 Lord, Dismiss Us with Thy Blessing")]
    Hymn163,
    [Description("164 Great God, to Thee My Evening Song")]
    Hymn164,
    [Description("165 Abide with Me; 'Tis Eventide")]
    Hymn165,
    [Description("167 Come, Let Us Sing an Evening Hymn")]
    Hymn167,
    [Description("168 As the Shadows Fall")]
    Hymn168,
    [Description("170 God, Our Father, Hear Us Pray")]
    Hymn170,
    [Description("172 In Humility, Our Savior")]
    Hymn172,
    [Description("173 While of These Emblems We Partake")]
    Hymn173,
    [Description("174 While of These Emblems We Partake")]
    Hymn174,
    [Description("176 'Tis Sweet to Sing the Matchless Love")]
    Hymn176,
    [Description("177 'Tis Sweet To Sing the Matchless Love")]
    Hymn177,
    [Description("178 O Lord of Hosts")]
    Hymn178,
    [Description("179 Again, Our Dear Redeeming Lord")]
    Hymn179,
    [Description("180 Father in Heaven, We Do Believe")]
    Hymn180,
    [Description("181 Jesus of Nazareth, Savior and King")]
    Hymn181,
    [Description("182 We'll Sing All Hail to Jesus' Name")]
    Hymn182,
    [Description("183 In Remembrance of Thy Suffering")]
    Hymn183,
    [Description("187 God Loved Us, So He Sent His Son")]
    Hymn187,
    [Description("188 Thy Will, O Lord, Be Done")]
    Hymn188,
    [Description("189 O Thou, Before the World Began")]
    Hymn189,
    [Description("191 Behold the Great Redeemer Die")]
    Hymn191,
    [Description("193 I Stand All Amazed")]
    Hymn193,
    [Description("195 How Great the Wisdom and the Love")]
    Hymn195,
    [Description("198 That Easter Morn")]
    Hymn198,
    [Description("205 Once in Royal David's City")]
    Hymn205,
    [Description("206 Away in a Manger")]
    Hymn206,
    [Description("208 O Little Town of Bethlehem")]
    Hymn208,
    [Description("209 Hark! The Herald Angels Sing")]
    Hymn209,
    [Description("210 With Wondering Awe")]
    Hymn210,
    [Description("211 While Shepherds Watched Their Flocks")]
    Hymn211,
    [Description("212 Far, Far Away on Judea's Plains")]
    Hymn212,
    [Description("213 The First Noel")]
    Hymn213,
    [Description("216 We Are Sowing")]
    Hymn216,
    [Description("217 Come, Let Us Anew")]
    Hymn217,
    [Description("218 We Give Thee But Thine Own")]
    Hymn218,
    [Description("220 Lord, I Would Follow Thee")]
    Hymn220,
    [Description("223 Have I Done Any Good?")]
    Hymn223,
    [Description("225 We Are Marching On to Glory")]
    Hymn225,
    [Description("226 Improve the Shining Moments")]
    Hymn226,
    [Description("230 Scatter Sunshine")]
    Hymn230,
    [Description("232 Let Us Oft Speak Kind Words")]
    Hymn232,
    [Description("234 Jesus, Mighty King in Zion")]
    Hymn234,
    [Description("237 Do What Is Right")]
    Hymn237,
    [Description("244 Come Along, Come Along")]
    Hymn244,
    [Description("245 This House We Dedicate to Thee")]
    Hymn245,
    [Description("246 Onward, Christian Soldiers")]
    Hymn246,
    [Description("247 We Love Thy House, O God")]
    Hymn247,
    [Description("248 Up, Awake, Ye Defenders of Zion")]
    Hymn248,
    [Description("252 Put Your Shoulder to the Wheel")]
    Hymn252,
    [Description("254 True to the Faith")]
    Hymn254,
    [Description("256 As Zion's Youth in Latter Days")]
    Hymn256,
    [Description("258 O Thou Rock of Our Salvation")]
    Hymn258,
    [Description("261 Thy Servants Are Prepared")]
    Hymn261,
    [Description("267 How Wondrous and Great")]
    Hymn267,
    [Description("269 Jehovah, Lord of Heaven and Earth")]
    Hymn269,
    [Description("270 I'll Go Where You Want Me to Go")]
    Hymn270,
    [Description("272 Oh Say, What Is Truth?")]
    Hymn272,
    [Description("273 Truth Reflects upon Our Senses")]
    Hymn273,
    [Description("274 The Iron Rod")]
    Hymn274,
    [Description("277 As I Search the Holy Scriptures")]
    Hymn277,
    [Description("279 Thy Holy Word")]
    Hymn279,
    [Description("280 Welcome, Welcome, Sabbath Morning")]
    Hymn280,
    [Description("281 Help Me Teach with Inspiration")]
    Hymn281,
    [Description("284 If You Could Hie to Kolob")]
    Hymn284,
    [Description("287 Rise, Ye Saints, and Temples Enter")]
    Hymn287,
    [Description("290 Rejoice, Ye Saints of Latter Days")]
    Hymn290,
    [Description("291 Turn Your Hearts")]
    Hymn291,
    [Description("293 Each Life That Touches Ours for Good")]
    Hymn293,
    [Description("295 O Love That Glorifies the Son")]
    Hymn295,
    [Description("296 Our Father, by Whose Name")]
    Hymn296,
    [Description("297 From Homes of Saints Glad Songs Arise")]
    Hymn297,
    [Description("298 Home Can Be a Heaven on Earth")]
    Hymn298,
    [Description("303 Keep the Commandments")]
    Hymn303,
    [Description("308 Love One Another")]
    Hymn308,
    [Description("309 As Sisters in Zion")]
    Hymn309,
    [Description("311 We Meet Again as Sisters")]
    Hymn311,
    [Description("317 Sweet Is the Work")]
    Hymn317,
    [Description("318 Love at Home")]
    Hymn318,
    [Description("319 Ye Elders of Israel")]
    Hymn319,
    [Description("320 The Priesthood of Our Lord")]
    Hymn320,
    [Description("321 Ye Who Are Called to Labor")]
    Hymn321,
    [Description("322 Come, All Ye Sons of God")]
    Hymn322,
    [Description("328 An Angel from on High")]
    Hymn328,
    [Description("333 High on the Mountain Top")]
    Hymn333,
    [Description("334 I Need Thee Every Hour")]
    Hymn334,
    [Description("335 Brightly Beams Our Father's Mercy")]
    Hymn335,
    [Description("336 School Thy Feelings")]
    Hymn336,
    [Description("337 O Home Beloved")]
    Hymn337,
    [Description("338 America the Beautiful")]
    Hymn338,
    [Description("339 My Country, 'Tis of Thee")]
    Hymn339,
    [Description("340 The Star-Spangled Banner")]
    Hymn340,
    [Description("341 God Save the King")]
    Hymn341
  }

  public enum Bishopric
  {
    [Description("Bishop Jones")]
    Bishop,
    [Description("Brother Smith")]
    FirstCounselor,
    [Description("Brother Green")]
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
}
