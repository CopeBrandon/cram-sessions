   M S B A M L   `   `   `  ???? H  Dcram-sessions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:cram_sessionscram_sessions      cram_sessions.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:cram_sessions     _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    ? Title$  Cram Sessions??$	??600??$	??800??   MaterialDesignBody#???   $??Medium"?$??14(?&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?   TextRenderingMode$
 Auto=?  MaterialDesignPaper#???    MaterialDesignFont#???  .??? $	??584??$	??Top=?.+?'  !MaterialDesignThemes.Wpf.Snackbar  -     Name$ Snackers???? $??Center=?$??Center=?$	??266??.+??? -    ??Name$ 	TitleText??$
??Wrap=?$S??MThis is some example text for the purposes of determing what text looks like.??$	??Top=? ?? TextAlignment$ Center=? J? RenderTransformOrigin$ 0.466,0.424&?$??Center=?$??0,50,0,0q?   MaterialDesignTitleTextBlock#???  ?? $??Number of Sessions???  ? ColumnDefinitions ?? $??45???? .+??? $??0??$??0??$??12(?$??Center=?$??10,10,10,10q?$
??Left=?????  ?? Path$ SessionCount??? -   	 ??Name$	 SessionCountSlider??$??0??$??1??$??10,10,10,10q?
 ?? AutoToolTipPlacement$
 TopLeft=? ? Maximum$ 10Q? ?? IsSnapToTickEnabled$
 True?? ? Value ?? $ SessionCount? ?? Mode$ OneWayToSource=??? $??Study Duration???  ?? $??45???? .+??? $??0??$??0??$??12(?$??Center=?$??10,10,10,10q?$
??Left=????? $ StudyDurationValue??? -   $	 StudyDurationSlider??$??0??$??1??$??10,10,10,10q?$
 TopLeft=? ?? TickFrequency$ 5Q?$
 True?? ?? $ StudyDurationValue?$ OneWayToSource=? ?? $ StudyLengthSlider?$ TwoWay=??? $??Rest Duration???  ?? $??45???? .+??? $??0??$??0??$??12(?$??Center=?$??10,10,10,10q?$
??Left=????? $ RestDurationValue??? -   $	 RestDurationSlider??$??0??$??1??$??10,10,10,10q?$
 TopLeft=?$ 5Q?$
 True?? ?? $ RestDurationValue?$ OneWayToSource=? ?? $ RestLengthSlider?$ TwoWay=??? $??Volume???  ?? $??45???? .+??? $??0??$??0??$??12(?$??Center=?$??10,10,10,10q?$
??Left=????? $ Volume??? -   $	 VolumeSlider??$??0??$??1??$??10,10,10,10q?$
 TopLeft=?$	 100Q? ?? $ Volume?$ OneWayToSource=??? $??Spotify URL(optional)???? $??10,10,10,10q????? $ 
SpotifyURL?$ OneWayToSource=??  ?? $
??auto ??? .+??? $??Shuffle????? $??10,0,0,0q?$??1?? d? 	IsChecked ?? *	isShuffle+$ OneWayToSource=??? -   $??40,20,40,20q?$
??auto??.???? $
??Wrap=?$'??!Debug Show Variables Or Run Maybe??$ Center=??? $
??Left=?$??
62,262,0,0q?$
??Wrap=?$	??Top=????? *tickCounter+$ TwoWay=?