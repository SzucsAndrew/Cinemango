BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Boritokep', N'Cim', N'ElozetesUrl', N'EredetiCim', N'ImdbId', N'KiadasEve', N'LeirasHtml') AND [object_id] = OBJECT_ID(N'[Filmek]'))
    SET IDENTITY_INSERT [Filmek] ON;
INSERT INTO [Filmek] ([Id], [Boritokep], [Cim], [ElozetesUrl], [EredetiCim], [ImdbId], [KiadasEve], [LeirasHtml])
VALUES (32563, NULL, N'Tenet', N'https://www.youtube.com/embed/AZGcmvrTX9M', N'Tenet', N'tt6723592', 2020, N'A legsikeresebb Batman-trilógia és az Eredet rendezője, <b>Christopher Nolan</b> ismét különlegesen egyedi, izgalmas és meghökkentő fordulatokban gazdag thrillert rendezett, amelyen egy angol kémnek kellene megmentenie a Földet a rá leselkedő és pusztulással fenyegető katasztrófától. Ám a szuperügynöknek nemcsak az idegen hatalmak embereivel, hanem a legnagyobb ellenséggel, <i>az Idővel is meg kell küzdenie</i>.<br>A főszerepet játszó <b>John David Washington</b> mellett fontos feladatot kapott a filmben Robert Pattinson, Kenneth Branagh, Aaron Taylor-Johnson, Elizabeth Debicki, Clémence Poésy és a Christopher Nolan filmjeiből (is) kihagyhatatlan Michael Caine is.'),
(4245, NULL, N'12 dühös ember', N'https://www.youtube.com/embed/A7CBKT0PWFA', N'12 Angry Men', N'tt0050083', 1957, N'Tizenkét embernek kell döntenie egy ember sorsáról: bűnös vagy nem bűnös. De hogyan hozhat egyhangú döntést, hogyan találhatja meg a közös nevezőt egy teljesen különböző emberekből álló társaság, akik még a szavak jelentésében sem tudnak megegyezni egymással?'),
(19821, NULL, N'Chihiro Szellemországban', N'https://www.youtube.com/embed/L5SjMRioGEk', N'Sen to Chihiro no kamikakushi | Spirited Away', N'tt0245429', 2001, N'Chihiro, a tízéves, önfejű kislány meg van győződve arról, hogy az egész világ körülötte forog - épp ezért képtelen belenyugodni abba, hogy szüleivel új városba költözik, és csalódottságát meg sem próbálja leplezni az utazás alatt. Amikor az erdőben eltévedve egy különös zsákutca végére érnek, a kis család rábukkan egy sötét alagútra, amelynek másik végén szellemváros fogadja őket. Az üres utcákon fejedelmi lakomától roskadoznak az asztalok: az éhes szülők mohón a finom ételekre vetik magukat, ám hamarosan disznóvá változnak, amikor a városban felbukkannak a valódi vacsoravendégek. Az eldugott mesevilág lakói ősi istenek és más csodalények, uralkodója pedig Yubaba, a gonosz boszorkány. Chihiro csak akkor mentheti meg szüleit, ha hasznossá teszi magát Szellemországban és munkát talál magának a banya hatalmas fürdőházában.'),
(8071, NULL, N'Hátsó ablak', N'https://www.youtube.com/embed/f9fz8q962Dc', N'Rear Window', N'tt0047396', 1954, N'A fényképész L. B. Jefferies (<b>James Stewart</b>) törött lába miatt ágyhoz van kötve. A férfi egyetlen szórakozása a szomszédok életének megfigyelése. A fényképész különös figyelmet fordít a Thornwald házaspárra: Lars Thornwald házaló ügynök, aki munkája mellett beteg feleségét is ápolja. Egy nap a nő eltűnik. Jefferies arra gyanakszik, hogy a férj gyilkolta meg az asszonyt. Magánnyomozásába bevonja gyönyörű barátnőjét, detektív barátját és az ápolónőjét. A további fejlemények drámai befejezést hoznak.'),
(7964, NULL, N'Ének az esőben', N'https://www.youtube.com/embed/5_EVHeNEIJY', N'Singin'' in the Rain', N'tt0045152', 1952, N'Az Ének az esőben az egyik legbájosabb zenés film, amit valaha vászonra vittek. Ki ne ismerné a képsort, amikor egy jókötésű férfi dalol és táncol egy szál esernyővel a rend ámuló őre előtt a zuhogó esőben? E rögtönzött előadás "tettese", Don Lockwood és barátja, Cosmo Brown a Monumental Picturesnél keresi a kenyerét. 1927-ben járunk, a némafilm a virágkorát éli. Egy szerencsés véletlennek köszönhetően Don népszerű sztár lesz, s filmek sorát forgatja az ünnepelt színésznő, Lina Lamont oldalán. A férfit távolról sem kötik mély érzelmek a mutatós, de üresfejű nőhöz, ám képzelt, a filmek által sugallt románcukat a sajtó szenzációként tálalja. Don valódi imádottja Kathy Selden, egy fiatal, kezdő énekes-táncosnő, akit a féltékeny Lina ukmukfukk kirúgat a stúdióból. Ám a sztárszínésznőt új veszély fenyegeti: a hangosfilm megjelenése. Lina ugyanis egyáltalán nem tud énekelni, sőt a beszédhangja is borzalmas. Sürgősen találnia kell valakit, aki "szinkronizálja" neki a dalokat és a dialógokat. Így kerül vissza a történetbe Kathy, aki azonkívül, hogy beszélni és énekelni is képes, csajnak is nagyon belevaló.');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Boritokep', N'Cim', N'ElozetesUrl', N'EredetiCim', N'ImdbId', N'KiadasEve', N'LeirasHtml') AND [object_id] = OBJECT_ID(N'[Filmek]'))
    SET IDENTITY_INSERT [Filmek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ar', N'Nev') AND [object_id] = OBJECT_ID(N'[JegyTipusok]'))
    SET IDENTITY_INSERT [JegyTipusok] ON;
INSERT INTO [JegyTipusok] ([Id], [Ar], [Nev])
VALUES (1, 3950, N'Normál'),
(2, 2950, N'Diák'),
(3, 3250, N'Nyugdíjas'),
(4, 3490, N'Családos (3+ fő)');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ar', N'Nev') AND [object_id] = OBJECT_ID(N'[JegyTipusok]'))
    SET IDENTITY_INSERT [JegyTipusok] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nev') AND [object_id] = OBJECT_ID(N'[Termek]'))
    SET IDENTITY_INSERT [Termek] ON;
INSERT INTO [Termek] ([Id], [Nev])
VALUES (1, N'Apricot'),
(2, N'Banana'),
(3, N'Cherry');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nev') AND [object_id] = OBJECT_ID(N'[Termek]'))
    SET IDENTITY_INSERT [Termek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (1, 1, 1, 1, 1),
(133, 1, 6, 1, 2),
(134, 2, 6, 1, 2),
(135, 1, 6, 2, 2),
(136, 2, 6, 2, 2),
(137, 1, 6, 3, 2),
(138, 2, 6, 3, 2),
(139, 1, 6, 4, 2),
(140, 2, 6, 4, 2),
(141, 1, 6, 5, 2),
(142, 2, 6, 5, 2),
(143, 1, 6, 6, 2),
(144, 2, 6, 6, 2),
(145, 1, 1, 1, 3),
(146, 2, 1, 1, 3),
(147, 1, 1, 2, 3),
(148, 2, 1, 2, 3),
(149, 1, 1, 3, 3),
(150, 2, 1, 3, 3),
(151, 1, 1, 4, 3),
(152, 2, 1, 4, 3),
(153, 1, 1, 5, 3),
(154, 2, 1, 5, 3),
(155, 1, 1, 6, 3),
(156, 2, 1, 6, 3),
(157, 1, 2, 1, 3),
(132, 2, 5, 6, 2),
(158, 2, 2, 1, 3),
(131, 1, 5, 6, 2),
(129, 1, 5, 5, 2),
(103, 1, 3, 4, 2),
(104, 2, 3, 4, 2),
(105, 1, 3, 5, 2),
(106, 2, 3, 5, 2),
(107, 1, 3, 6, 2),
(108, 2, 3, 6, 2),
(109, 1, 4, 1, 2),
(110, 2, 4, 1, 2),
(111, 1, 4, 2, 2),
(112, 2, 4, 2, 2),
(113, 1, 4, 3, 2),
(114, 2, 4, 3, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (115, 1, 4, 4, 2),
(116, 2, 4, 4, 2),
(117, 1, 4, 5, 2),
(118, 2, 4, 5, 2),
(120, 2, 4, 6, 2),
(121, 1, 5, 1, 2),
(122, 2, 5, 1, 2),
(123, 1, 5, 2, 2),
(124, 2, 5, 2, 2),
(125, 1, 5, 3, 2),
(126, 2, 5, 3, 2),
(127, 1, 5, 4, 2),
(128, 2, 5, 4, 2),
(130, 2, 5, 5, 2),
(159, 1, 2, 2, 3),
(160, 2, 2, 2, 3),
(161, 1, 2, 3, 3),
(192, 2, 4, 6, 3),
(193, 1, 5, 1, 3),
(194, 2, 5, 1, 3),
(195, 1, 5, 2, 3),
(196, 2, 5, 2, 3),
(197, 1, 5, 3, 3),
(198, 2, 5, 3, 3),
(199, 1, 5, 4, 3),
(200, 2, 5, 4, 3),
(201, 1, 5, 5, 3),
(202, 2, 5, 5, 3),
(203, 1, 5, 6, 3),
(204, 2, 5, 6, 3),
(205, 1, 6, 1, 3),
(206, 2, 6, 1, 3),
(207, 1, 6, 2, 3),
(208, 2, 6, 2, 3),
(209, 1, 6, 3, 3),
(210, 2, 6, 3, 3),
(211, 1, 6, 4, 3),
(212, 2, 6, 4, 3),
(213, 1, 6, 5, 3),
(214, 2, 6, 5, 3),
(215, 1, 6, 6, 3),
(216, 2, 6, 6, 3);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (191, 1, 4, 6, 3),
(190, 2, 4, 5, 3),
(189, 1, 4, 5, 3),
(188, 2, 4, 4, 3),
(162, 2, 2, 3, 3),
(163, 1, 2, 4, 3),
(164, 2, 2, 4, 3),
(165, 1, 2, 5, 3),
(166, 2, 2, 5, 3),
(167, 1, 2, 6, 3),
(168, 2, 2, 6, 3),
(169, 1, 3, 1, 3),
(170, 2, 3, 1, 3),
(171, 1, 3, 2, 3),
(172, 2, 3, 2, 3),
(173, 1, 3, 3, 3),
(102, 2, 3, 3, 2),
(174, 2, 3, 3, 3),
(176, 2, 3, 4, 3),
(177, 1, 3, 5, 3),
(178, 2, 3, 5, 3),
(179, 1, 3, 6, 3),
(180, 2, 3, 6, 3),
(181, 1, 4, 1, 3),
(182, 2, 4, 1, 3),
(183, 1, 4, 2, 3),
(184, 2, 4, 2, 3),
(185, 1, 4, 3, 3),
(186, 2, 4, 3, 3),
(187, 1, 4, 4, 3),
(175, 1, 3, 4, 3),
(101, 1, 3, 3, 2),
(119, 1, 4, 6, 2),
(99, 1, 3, 2, 2),
(35, 1, 3, 6, 1),
(36, 2, 3, 6, 1),
(37, 1, 4, 1, 1),
(38, 2, 4, 1, 1),
(39, 1, 4, 2, 1),
(40, 2, 4, 2, 1),
(41, 1, 4, 3, 1),
(42, 2, 4, 3, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (43, 1, 4, 4, 1),
(44, 2, 4, 4, 1),
(45, 1, 4, 5, 1),
(46, 2, 4, 5, 1),
(47, 1, 4, 6, 1),
(34, 2, 3, 5, 1),
(48, 2, 4, 6, 1),
(50, 2, 5, 1, 1),
(51, 1, 5, 2, 1),
(52, 2, 5, 2, 1),
(53, 1, 5, 3, 1),
(100, 2, 3, 2, 2),
(55, 1, 5, 4, 1),
(56, 2, 5, 4, 1),
(57, 1, 5, 5, 1),
(58, 2, 5, 5, 1),
(59, 1, 5, 6, 1),
(60, 2, 5, 6, 1),
(61, 1, 6, 1, 1),
(62, 2, 6, 1, 1),
(49, 1, 5, 1, 1),
(33, 1, 3, 5, 1),
(32, 2, 3, 4, 1),
(31, 1, 3, 4, 1),
(2, 2, 1, 1, 1),
(3, 1, 1, 2, 1),
(4, 2, 1, 2, 1),
(5, 1, 1, 3, 1),
(6, 2, 1, 3, 1),
(7, 1, 1, 4, 1),
(8, 2, 1, 4, 1),
(9, 1, 1, 5, 1),
(10, 2, 1, 5, 1),
(11, 1, 1, 6, 1),
(12, 2, 1, 6, 1),
(13, 1, 2, 1, 1),
(14, 2, 2, 1, 1),
(15, 1, 2, 2, 1),
(16, 2, 2, 2, 1),
(17, 1, 2, 3, 1),
(18, 2, 2, 3, 1),
(19, 1, 2, 4, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (20, 2, 2, 4, 1),
(21, 1, 2, 5, 1),
(22, 2, 2, 5, 1),
(23, 1, 2, 6, 1),
(24, 2, 2, 6, 1),
(25, 1, 3, 1, 1),
(26, 2, 3, 1, 1),
(27, 1, 3, 2, 1),
(28, 2, 3, 2, 1),
(29, 1, 3, 3, 1),
(30, 2, 3, 3, 1),
(63, 1, 6, 2, 1),
(64, 2, 6, 2, 1),
(54, 2, 5, 3, 1),
(66, 2, 6, 3, 1),
(75, 1, 1, 2, 2),
(76, 2, 1, 2, 2),
(77, 1, 1, 3, 2),
(78, 2, 1, 3, 2),
(79, 1, 1, 4, 2),
(65, 1, 6, 3, 1),
(81, 1, 1, 5, 2),
(82, 2, 1, 5, 2),
(83, 1, 1, 6, 2),
(84, 2, 1, 6, 2),
(85, 1, 2, 1, 2),
(74, 2, 1, 1, 2),
(86, 2, 2, 1, 2),
(88, 2, 2, 2, 2),
(89, 1, 2, 3, 2),
(90, 2, 2, 3, 2),
(91, 1, 2, 4, 2),
(92, 2, 2, 4, 2),
(93, 1, 2, 5, 2),
(94, 2, 2, 5, 2),
(95, 1, 2, 6, 2),
(96, 2, 2, 6, 2),
(97, 1, 3, 1, 2),
(98, 2, 3, 1, 2),
(87, 1, 2, 2, 2),
(73, 1, 1, 1, 2),
(80, 2, 1, 4, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] ON;
INSERT INTO [Ulohelyek] ([Id], [Oldal], [Sor], [Szek], [TeremId])
VALUES (72, 2, 6, 6, 1),
(70, 2, 6, 5, 1),
(69, 1, 6, 5, 1),
(68, 2, 6, 4, 1),
(67, 1, 6, 4, 1),
(71, 1, 6, 6, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Oldal', N'Sor', N'Szek', N'TeremId') AND [object_id] = OBJECT_ID(N'[Ulohelyek]'))
    SET IDENTITY_INSERT [Ulohelyek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FilmId', N'Idopont', N'TeremId', N'Tipus') AND [object_id] = OBJECT_ID(N'[Vetitesek]'))
    SET IDENTITY_INSERT [Vetitesek] ON;
INSERT INTO [Vetitesek] ([Id], [FilmId], [Idopont], [TeremId], [Tipus])
VALUES (1213, 32563, '2000-01-07T18:45:00.0000000', 3, 4),
(1214, 32563, '2000-01-03T18:00:00.0000000', 3, 1),
(1215, 32563, '2000-01-07T18:00:00.0000000', 3, 4),
(1216, 32563, '2000-01-02T18:00:00.0000000', 3, 3),
(1217, 32563, '2000-01-04T20:15:00.0000000', 3, 4),
(1223, 4245, '2000-01-04T18:00:00.0000000', 3, 4),
(1225, 4245, '2000-01-05T20:15:00.0000000', 3, 1),
(1231, 4245, '2000-01-06T19:15:00.0000000', 3, 2),
(1233, 19821, '2000-01-06T20:15:00.0000000', 3, 2),
(1237, 19821, '2000-01-05T18:45:00.0000000', 3, 1),
(1238, 19821, '2000-01-04T19:40:00.0000000', 3, 1),
(1244, 8071, '2000-01-03T19:15:00.0000000', 3, 3),
(1245, 8071, '2000-01-05T18:45:00.0000000', 3, 4),
(1248, 8071, '2000-01-06T20:00:00.0000000', 3, 4),
(1250, 8071, '2000-01-04T18:45:00.0000000', 3, 1),
(1252, 8071, '2000-01-06T18:00:00.0000000', 3, 1),
(1253, 8071, '2000-01-06T19:15:00.0000000', 3, 4),
(1256, 7964, '2000-01-06T20:00:00.0000000', 3, 2),
(1257, 7964, '2000-01-02T21:10:00.0000000', 3, 1),
(1259, 7964, '2000-01-01T19:15:00.0000000', 3, 1),
(1261, 7964, '2000-01-04T19:15:00.0000000', 3, 3),
(1236, 19821, '2000-01-01T20:15:00.0000000', 3, 3),
(1241, 19821, '2000-01-07T20:15:00.0000000', 1, 2),
(1242, 8071, '2000-01-07T19:15:00.0000000', 1, 3),
(1258, 7964, '2000-01-03T18:10:00.0000000', 2, 2),
(1243, 8071, '2000-01-06T20:00:00.0000000', 1, 1),
(1246, 8071, '2000-01-02T20:15:00.0000000', 1, 1),
(1247, 8071, '2000-01-05T19:40:00.0000000', 1, 1),
(1249, 8071, '2000-01-05T20:00:00.0000000', 1, 1),
(1254, 8071, '2000-01-02T20:15:00.0000000', 1, 4),
(1255, 7964, '2000-01-04T18:10:00.0000000', 1, 1),
(1260, 7964, '2000-01-03T19:15:00.0000000', 1, 2),
(1240, 19821, '2000-01-02T18:00:00.0000000', 1, 1),
(1234, 19821, '2000-01-02T20:00:00.0000000', 1, 1),
(1230, 4245, '2000-01-05T21:10:00.0000000', 1, 4),
(1226, 4245, '2000-01-07T18:10:00.0000000', 1, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FilmId', N'Idopont', N'TeremId', N'Tipus') AND [object_id] = OBJECT_ID(N'[Vetitesek]'))
    SET IDENTITY_INSERT [Vetitesek] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FilmId', N'Idopont', N'TeremId', N'Tipus') AND [object_id] = OBJECT_ID(N'[Vetitesek]'))
    SET IDENTITY_INSERT [Vetitesek] ON;
INSERT INTO [Vetitesek] ([Id], [FilmId], [Idopont], [TeremId], [Tipus])
VALUES (1224, 4245, '2000-01-02T18:10:00.0000000', 1, 3),
(1212, 32563, '2000-01-07T18:45:00.0000000', 1, 1),
(1222, 4245, '2000-01-03T19:15:00.0000000', 1, 4),
(1218, 32563, '2000-01-06T19:40:00.0000000', 2, 2),
(1219, 32563, '2000-01-07T19:40:00.0000000', 2, 1),
(1220, 32563, '2000-01-04T21:10:00.0000000', 2, 4),
(1262, 7964, '2000-01-02T20:15:00.0000000', 3, 3),
(1221, 32563, '2000-01-02T19:40:00.0000000', 2, 4),
(1227, 4245, '2000-01-01T20:15:00.0000000', 2, 3),
(1228, 4245, '2000-01-03T18:45:00.0000000', 2, 3),
(1229, 4245, '2000-01-02T21:10:00.0000000', 2, 3),
(1232, 4245, '2000-01-01T18:45:00.0000000', 2, 1),
(1235, 19821, '2000-01-03T19:15:00.0000000', 2, 1),
(1239, 19821, '2000-01-03T18:10:00.0000000', 2, 4),
(1251, 8071, '2000-01-02T18:00:00.0000000', 2, 2),
(1211, 32563, '2000-01-06T20:00:00.0000000', 2, 4),
(1263, 7964, '2000-01-01T20:15:00.0000000', 3, 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FilmId', N'Idopont', N'TeremId', N'Tipus') AND [object_id] = OBJECT_ID(N'[Vetitesek]'))
    SET IDENTITY_INSERT [Vetitesek] OFF;
GO

UPDATE VETITESEK SET Idopont = DATEADD(year, YEAR(SYSDATETIME()) - 2000, Idopont);
UPDATE VETITESEK SET Idopont = DATEADD(month, MONTH(SYSDATETIME()) - 1, Idopont);
UPDATE VETITESEK SET Idopont = DATEADD(day, DAY(SYSDATETIME()), Idopont);

COMMIT;
GO

