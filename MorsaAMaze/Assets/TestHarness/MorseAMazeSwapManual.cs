﻿using System.IO;

namespace Assets.Scripts.RuleGenerator
{
    public partial class MorseAMazeSwapRuleGenerator
    {
        public string Manual = @"<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv=""content-type"" content=""text/html; charset=UTF-8"">
        <meta charset=""utf-8"">
        <title>Morse-A-Maze-Swap — Keep Talking and Nobody Explodes Module</title>
        <meta name=""viewport"" content=""initial-scale=1"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/normalize.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/main.css"">
        <link rel=""stylesheet"" type='text/css' href=""css/font.css"">
        <style>
        	ul {
			    margin: 0;
			    padding: 0;
			    margin-left: 24px;
			}
			#morseMazeChart {
			    margin-right: 1em;
			    height: 29em;
			    width: 22.8270625em; /* Hardcode for IE */
			    border:1px solid #021a40;
			    background-color:#ffffff;
			}
			.morseMaze {
			    width:13em;
			    height:13em;
			}
        </style>
    </head>
    <body>
        <div id=""ManualContent"">
            <div class=""section"">
                <div class=""page page-bg-02"">
                    <div class=""page-header"">
                        <span class=""page-header-doc-title"">Keep Talking and Nobody Explodes Mod</span>
                        <span class=""page-header-section-title"">Morse-A-Maze-Swap</span>
                    </div>
                    <div class=""page-content"">
                    	<img src=""img/Component/Morse-A-Maze-Swap.svg"" class=""diagram"" />
						<h2>On the Subject of Morse-A-Maze-Swap</h2>
						<p class=""flavour-text"">Wait what? Now the status light is even more lost.</p>
						<ul>
							<li>Decode the Morse code from the blinking status light. Off state is green, On state is red.**</li>
							<li>The first thing transmitted is the cyan maze word.</li>
							<li>The second thing transmitted is the magenta maze word.</li>
							<li>The third thing transmitted is the coordinates the status light needs to be placed on. Coordinates are a letter from A–F, representing columns, followed by a number from 1–6, representing rows. The upper left is A1.</li>
							<li>If the word is listed in Table 1, use the corresponding information in the table to determine which maze to look up. If the number you get is greater than 18, keep subtracting 18 until you are in the range of 0–17.</li>
							<li>Otherwise, look up the word in Tables 2 and 3.</li>
							<li><strong>Warning:</strong> Do not cross the lines shown in the maze. These lines are invisible on the bomb. The wall colors determine your current maze.</li>
							<li>If there is an unlit BOB indicator and 4 batteries in 3 holders in the configuration of 2×AA and 2×D, Bob will actively prevent you from earning any strikes. Thanks Bob.</li>
						</ul>
						Table 1:
						<table>
							<tr><td>EDGEWORKWORD01*</td><td colspan=""3""><ul><li>If any two-factor widgets are present, use the sum of the 2nd least significant digit of each two-factor code.</li>
								<li>Otherwise, use the number of unsolved modules.</li></ul></td></tr>
							<tr><td>EDGEWORKWORD02*</td><td>Number of solved modules</td><td>EDGEWORKWORD03*</td><td>Number of strikes</td></tr>
							<tr><td>EDGEWORKWORD04</td><td>Number of battery holders</td><td>EDGEWORKWORD05</td><td>Number of unique ports</td></tr>
							<tr><td>EDGEWORKWORD06</td><td>Total number of ports</td><td>EDGEWORKWORD07</td><td>Number of lit indicators</td></tr>
							<tr><td>EDGEWORKWORD08</td><td>Number of unlit indicators</td><td>EDGEWORKWORD09</td><td>Number of indicators</td></tr>
							<tr><td>EDGEWORKWORD10</td><td>Number of port plates</td><td>EDGEWORKWORD11</td><td>The last digit of the serial number</td></tr>
							<tr><td>EDGEWORKWORD12</td><td>The sum of the serial number digits</td><td>EDGEWORKWORD13</td><td>Number of batteries</td></tr>
							<tr><td>EDGEWORKWORD14</td><td>First serial number digit</td><td>EDGEWORKWORD15</td><td>Starting time in minutes</td></tr>
							<tr><td>EDGEWORKWORD16</td><td>Day of week at bomb start<br>(Sunday = 0, Saturday = 6).</td><td>EDGEWORKWORD17</td><td>Number of empty port plates</td></tr>
							<tr><td>EDGEWORKWORD18</td><td colspan=""3"">Position of first serial number letter minus one (A=0, B=1, C=2, ...)</td></tr>
						</table>
						* - The maze for these words can change.<br>
						** - Refer to page 4 for some configuration options.
					</div>
					<div class=""page-footer relative-footer"">Page 1 of 4</div>
                </div>
                <div class=""page page-bg-02"">
                    <div class=""page-header"">
                        <span class=""page-header-doc-title"">Keep Talking and Nobody Explodes Mod</span>
                        <span class=""page-header-section-title"">Morse-A-Maze-Swap</span>
                    </div>
                    <div class=""page-content"">						
							Table 2:
							<table style=""border: none"">
								<tr>
									<td>MAZEWORD01</td>
									<td>MAZEWORD02</td>
									<td>MAZEWORD03</td>
								</tr>
								<tr>
									<td>MAZEWORD04</td>
									<td>MAZEWORD05</td>
									<td>MAZEWORD06</td>
								</tr>
								<tr>
									<td>MAZEWORD07</td>
									<td>MAZEWORD08</td>
									<td>MAZEWORD09</td>
								</tr>

							</table>
					</div>
					<div class=""page-footer relative-footer"">Page 2 of 4</div>
                </div>
                <div class=""page page-bg-03"">
                    <div class=""page-header"">
                        <span class=""page-header-doc-title"">Keep Talking and Nobody Explodes Mod</span>
                        <span class=""page-header-section-title"">Morse-A-Maze-Swap</span>
                    </div>
                    <div class=""page-content"">
                    	Table 3:
                    	<table style=""border: none"">
								<tr>
									<td>MAZEWORD10</td>
									<td>MAZEWORD11</td>
									<td>MAZEWORD12</td>
								</tr>
								<tr>
									<td>MAZEWORD13</td>
									<td>MAZEWORD14</td>
									<td>MAZEWORD15</td>
								</tr>
								<tr>
									<td>MAZEWORD16</td>
									<td>MAZEWORD17</td>
									<td>MAZEWORD18</td>
								</tr>
							</table>
                    </div>
                   <div class=""page-footer relative-footer"">Page 3 of 4</div>
                </div>
                <div class=""page page-bg-04"">
                    <div class=""page-header"">
                        <span class=""page-header-doc-title"">Keep Talking and Nobody Explodes Mod</span>
                        <span class=""page-header-section-title"">Morse-A-Maze-Swap</span>
                    </div>
                    <div class=""page-content"">
                    	<img id=""morseMazeChart"" src=""img/Morse-A-Maze-Swap/International_Morse_Code.svg"">
                    	<p><em>Configuration Options for <strong>MorseAMaze-settings.txt</strong></em><br>
                    	It is possible to change the colors of the status light for the various states of the module.  
                    		The following colors are possible.</p>
                    	<ul>
                    		<li>0 - Off</li>
                    		<li>1 - Green</li>
                    		<li>2 - Red</li>
                    		<li>3 - Random</li>
                    	</ul>
                    	<p>These are the options that can be configured, and their default values.</p>
                    	<ul>
                    		<li><strong>SolvedState</strong> - The state the status light changes to once the module is solved. 
                    			(default: <b>Off</b>)</li>
                    		<li><strong>StrikeState</strong> - The state the status light changes to for one second when a strike is earned. 
                    			(default: <b>Off</b>)</li>
                    		<li><strong>OffState</strong> - The off state of the status light while morse code is being transmitted. 
                    			(default: <b>Green</b>)</li>
                    		<li><strong>MorseXmitState</strong> - The on state of the status light while morse code is being transmitted. 
                    			(default: <b>Red</b>)</li>
                    	</ul>
                    	<p>Finally, if you wish to reset everything back to default, just change ""<b>ResetToDefault</b>"" 
                    		from <b><em>false</em></b> to <b><em>true</em></b></p> 
                    </div>
                   <div class=""page-footer relative-footer"">Page 4 of 4</div>
                </div>
            </div>
        </div>
    </body>
</html>";

        public static string[] ImagePaths = 
        {
            Path.Combine("img", "Component"),
            Path.Combine("img", "Morse-A-Maze-Swap")
        };

        public static string[] TextAssetPaths = 
        {
            Path.Combine(ImagePaths[0],"Morse-A-Maze-Swap.svg"),
            Path.Combine(ImagePaths[1],"International_Morse_Code.svg")
        };

        public static string[] TextAssets = 
        {
            "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?><svg xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:cc=\"http://creativecommons.org/ns#\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:svg=\"http://www.w3.org/2000/svg\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:sodipodi=\"http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd\" xmlns:inkscape=\"http://www.inkscape.org/namespaces/inkscape\" viewBox=\"0.0 0.0 348.0 348.0\" fill=\"none\" stroke-linecap=\"square\" stroke-miterlimit=\"10\" id=\"svg2\" version=\"1.1\" inkscape:version=\"0.91 r13725\" sodipodi:docname=\"MorseAMaze.svg\"> <metadata id=\"metadata197\"> <rdf:RDF> <cc:Work rdf:about=\"\"> <dc:format>image/svg+xml</dc:format> <dc:type rdf:resource=\"http://purl.org/dc/dcmitype/StillImage\" /> </cc:Work> </rdf:RDF> </metadata> <defs id=\"defs195\" /> <sodipodi:namedview pagecolor=\"#ffffff\" bordercolor=\"#666666\" borderopacity=\"1\" objecttolerance=\"10\" gridtolerance=\"10\" guidetolerance=\"10\" inkscape:pageopacity=\"0\" inkscape:pageshadow=\"2\" inkscape:window-width=\"1920\" inkscape:window-height=\"1017\" id=\"namedview193\" showgrid=\"false\" inkscape:zoom=\"2.7126437\" inkscape:cx=\"229.61352\" inkscape:cy=\"173.34754\" inkscape:window-x=\"-8\" inkscape:window-y=\"-8\" inkscape:window-maximized=\"1\" inkscape:current-layer=\"svg2\" /> <clipPath id=\"a\"> <path d=\"M0 0h348v348H0V0z\" id=\"path5\" /> </clipPath> <path style=\"fill:#000000;fill-opacity:0\" inkscape:connector-curvature=\"0\" id=\"path9\" d=\"m 0.36864407,-9.5847457 347.99999593,0 0,347.9999957 -347.99999593,0 z\" /> <path style=\"fill:#000000;fill-opacity:0\" inkscape:connector-curvature=\"0\" id=\"path13\" d=\"m 5.4476441,-3.8087457 336.9129959,0 0,337.6699957 -336.9119959,0 z\" /> <path style=\"stroke:#000000;stroke-width:1.94050419;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path15\" d=\"m 5.4178962,16.068286 336.9724838,0 0,317.822704 -336.9714837,0 z\" /> <path style=\"stroke:#000000;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path23\" d=\"m 43.091644,52.544254 263.149996,0 0,246.077996 -263.149996,0 z\" /> <path style=\"fill:#000000\" inkscape:connector-curvature=\"0\" id=\"path25\" d=\"M 37.202931,55.509769 12.335657,175.53535 37.202931,295.55645 Z\" /> <path style=\"stroke:#000000;stroke-width:4.42384386;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path27\" d=\"M 37.202931,55.509769 12.335657,175.53535 37.202931,295.55645 Z\" /> <path style=\"fill:#000000\" inkscape:connector-curvature=\"0\" id=\"path29\" d=\"M 312.07335,295.96729 335.91814,175.53536 312.07335,55.09892 Z\" /> <path style=\"stroke:#000000;stroke-width:4.33944178;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path31\" d=\"M 312.07335,295.96729 335.91814,175.53536 312.07335,55.09892 Z\" /> <path style=\"fill:#000000\" inkscape:connector-curvature=\"0\" id=\"path33\" d=\"M 45.42543,304.52902 173.91806,327.90648 302.4155,304.52902 Z\" /> <path style=\"stroke:#000000;stroke-width:4.43817234;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path35\" d=\"M 45.42543,304.52902 173.91806,327.90648 302.4155,304.52902 Z\" /> <path style=\"fill:#000000\" inkscape:connector-curvature=\"0\" id=\"path37\" d=\"M 44.841028,46.021778 173.58102,23.993258 302.32585,46.021778 Z\" /> <path style=\"stroke:#000000;stroke-width:4.31236839;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path39\" d=\"M 44.841028,46.021778 173.58102,23.993258 302.32585,46.021778 Z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path41\" d=\"m 68.098644,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path43\" d=\"m 68.098644,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path45\" d=\"m 107.18564,72.229254 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path47\" d=\"m 107.18564,72.229254 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path49\" d=\"m 146.27364,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path51\" d=\"m 146.27364,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path53\" d=\"m 185.36064,72.229254 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path55\" d=\"m 185.36064,72.229254 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path57\" d=\"m 224.44864,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path59\" d=\"m 224.44864,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path61\" d=\"m 263.53664,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path63\" d=\"m 263.53664,72.229254 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path65\" d=\"m 68.098644,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path67\" d=\"m 68.098644,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path69\" d=\"m 107.18564,108.01025 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path71\" d=\"m 107.18564,108.01025 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path73\" d=\"m 146.27364,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path75\" d=\"m 146.27364,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path77\" d=\"m 185.36064,108.01025 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path79\" d=\"m 185.36064,108.01025 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path85\" d=\"m 263.53664,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path87\" d=\"m 263.53664,108.01025 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path89\" d=\"m 68.098644,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path91\" d=\"m 68.098644,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path93\" d=\"m 107.18564,143.79125 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path95\" d=\"m 107.18564,143.79125 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path97\" d=\"m 146.27364,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path99\" d=\"m 146.27364,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path101\" d=\"m 185.36064,143.79125 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path103\" d=\"m 185.36064,143.79125 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path105\" d=\"m 224.44864,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path107\" d=\"m 224.44864,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path109\" d=\"m 263.53664,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path111\" d=\"m 263.53664,143.79125 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path113\" d=\"m 68.098644,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path115\" d=\"m 68.098644,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path117\" d=\"m 107.18564,179.57225 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path119\" d=\"m 107.18564,179.57225 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path121\" d=\"m 146.27364,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path123\" d=\"m 146.27364,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path125\" d=\"m 185.36064,179.57225 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path127\" d=\"m 185.36064,179.57225 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path129\" d=\"m 263.53664,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path131\" d=\"m 263.53664,179.57225 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path133\" d=\"m 68.098644,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path135\" d=\"m 68.098644,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path137\" d=\"m 107.18564,215.35325 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path139\" d=\"m 107.18564,215.35325 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path141\" d=\"m 146.27364,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path143\" d=\"m 146.27364,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path145\" d=\"m 185.36064,215.35325 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path147\" d=\"m 185.36064,215.35325 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path149\" d=\"m 224.44864,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path151\" d=\"m 224.44864,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path153\" d=\"m 263.53664,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path155\" d=\"m 263.53664,215.35325 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path157\" d=\"m 68.098644,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path159\" d=\"m 68.098644,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path161\" d=\"m 107.18564,251.13525 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path163\" d=\"m 107.18564,251.13525 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path165\" d=\"m 146.27364,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path167\" d=\"m 146.27364,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path169\" d=\"m 185.36064,251.13525 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path171\" d=\"m 185.36064,251.13525 17.701,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path173\" d=\"m 224.44864,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path175\" d=\"m 224.44864,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path177\" d=\"m 263.53664,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path179\" d=\"m 263.53664,251.13525 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#000000;fill-opacity:0\" inkscape:connector-curvature=\"0\" id=\"path181\" d=\"m 95.609644,152.02825 c 0,-10.959 9.017996,-19.843 20.141996,-19.843 5.342,0 10.465,2.09 14.243,5.812 3.777,3.721 5.899,8.768 5.899,14.03 0,10.96 -9.018,19.843 -20.142,19.843 -11.124,0 -20.141996,-8.883 -20.141996,-19.842 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path183\" d=\"m 95.609644,152.02825 c 0,-10.959 9.017996,-19.843 20.141996,-19.843 5.342,0 10.465,2.09 14.243,5.812 3.777,3.721 5.899,8.768 5.899,14.03 0,10.96 -9.018,19.843 -20.142,19.843 -11.124,0 -20.141996,-8.883 -20.141996,-19.842 z\" /> <path style=\"fill:none;fill-opacity:1;stroke:#000000;stroke-width:3.9000001;stroke-miterlimit:10;stroke-dasharray:none;stroke-opacity:1\" inkscape:connector-curvature=\"0\" id=\"path185\" d=\"m 135.17473,152.00372 c 0,-10.96 9.018,-19.843 20.142,-19.843 5.342,0 10.465,2.09 14.243,5.812 3.777,3.72 5.899,8.768 5.899,14.03 0,10.96 -9.018,19.843 -20.142,19.843 -11.124,0 -20.141,-8.884 -20.141,-19.843 z\" /> <path style=\"stroke:#ffffff;stroke-width:2;stroke-linecap:butt;stroke-linejoin:round\" inkscape:connector-curvature=\"0\" id=\"path107-1\" d=\"m 224.03692,179.51157 17.7,0 0,16.472 -17.7,0 z\" /> <path style=\"fill:#ffffff\" inkscape:connector-curvature=\"0\" id=\"path105-8\" d=\"m 224.03692,178.99023 17.7,0 0,16.472 -17.7,0 z\" /> <g inkscape:groupmode=\"layer\" id=\"layer1\" inkscape:label=\"Circles\" style=\"display:inline\"> <g transform=\"translate(0.20572073,26.192311)\" id=\"g4557-2\"> <g transform=\"translate(-0.26067072,0)\" id=\"g4479-47\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-0\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-9\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-4\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-4-4\" transform=\"translate(38.774769,-0.06517071)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-6-3\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-4-8\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-1-6\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-45-6\" transform=\"translate(78.005714,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-5-0\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-5-2\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-6-3\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-0-7\" transform=\"translate(116.97599,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-8-7\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-8-7\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-0-0\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-9-2\" transform=\"translate(156.07659,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-68-1\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-3-2\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-3-5\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-2-4\" transform=\"translate(195.17721,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-2-8\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-34-4\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-04-5\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> </g> </g> <g id=\"g4479\" transform=\"translate(0.10797335,-9.5847457)\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(39.143413,-9.6499164)\" id=\"g4479-4\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-6\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-4\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-1\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(78.374358,-9.519581)\" id=\"g4479-45\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-5\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-5\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-6\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(117.34463,-9.519581)\" id=\"g4479-0\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-8\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-8\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-0\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(156.44523,-9.519581)\" id=\"g4479-9\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-68\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-3\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-3\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(195.54585,-9.519581)\" id=\"g4479-2\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-2\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-34\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-04\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g> <g transform=\"translate(0.46639141,61.643529)\" id=\"g4557-9\"> <g transform=\"translate(-0.26067072,0)\" id=\"g4479-94\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-3\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-54\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-8\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-4-9\" transform=\"translate(38.774769,-0.06517071)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-6-0\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-4-5\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-1-5\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-45-2\" transform=\"translate(78.005714,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-5-04\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-5-1\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-6-4\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-0-9\" transform=\"translate(116.97599,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-8-3\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-8-3\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-0-1\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-9-8\" transform=\"translate(156.07659,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-68-5\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-3-1\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-3-7\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-2-2\" transform=\"translate(195.17721,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-2-0\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-34-1\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-04-8\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> </g> <g transform=\"translate(0.46639146,97.616084)\" id=\"g4557-25\"> <g transform=\"translate(-0.26067072,0)\" id=\"g4479-453\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-7\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-83\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-2\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-4-7\" transform=\"translate(38.774769,-0.06517071)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-6-1\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-4-4\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-1-2\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-45-3\" transform=\"translate(78.005714,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-5-6\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-5-3\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-6-0\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-0-1\" transform=\"translate(116.97599,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-8-4\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-8-2\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-0-6\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-9-26\" transform=\"translate(156.07659,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-68-7\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-3-6\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-3-1\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-2-47\" transform=\"translate(195.17721,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-2-6\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-34-6\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-04-2\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> </g> <g transform=\"translate(0.46639145,133.58865)\" id=\"g4557-0\"> <g transform=\"translate(-0.26067072,0)\" id=\"g4479-455\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-80\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-6\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-87\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-4-8\" transform=\"translate(38.774769,-0.06517071)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-6-5\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-4-9\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-1-61\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-45-65\" transform=\"translate(78.005714,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-5-06\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-5-9\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-6-6\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-0-4\" transform=\"translate(116.97599,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-8-0\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-8-37\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-0-3\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-9-20\" transform=\"translate(156.07659,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-68-9\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-3-4\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-3-4\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-2-5\" transform=\"translate(195.17721,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-2-3\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-34-60\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-04-86\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> </g> <g transform=\"translate(0.46639147,169.03986)\" id=\"g4557-4\"> <g transform=\"translate(-0.26067072,0)\" id=\"g4479-8\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-57\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-84\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-83\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-4-2\" transform=\"translate(38.774769,-0.06517071)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-6-17\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-4-0\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-1-8\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-45-24\" transform=\"translate(78.005714,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-5-66\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-5-8\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-6-9\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-0-6\" transform=\"translate(116.97599,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-8-6\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-8-9\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-0-30\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-9-209\" transform=\"translate(156.07659,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-68-4\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-3-5\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-3-8\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> <g id=\"g4479-2-50\" transform=\"translate(195.17721,0.06516465)\"> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4471-2-1\" cx=\"76.832695\" cy=\"90.131493\" rx=\"9.9706554\" ry=\"9.3189783\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4475-34-5\" cx=\"77.288872\" cy=\"89.870819\" rx=\"5.6044207\" ry=\"5.4089174\" /> <ellipse style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" id=\"path4477-04-21\" cx=\"77.614708\" cy=\"90.131493\" rx=\"2.8022103\" ry=\"2.4112041\" /> </g> </g> <g transform=\"translate(246.8368,-53.635727)\" id=\"g4479-2-1\"> <ellipse ry=\"9.3189783\" rx=\"9.9706554\" cy=\"90.131493\" cx=\"76.832695\" id=\"path4471-2-4\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"5.4089174\" rx=\"5.6044207\" cy=\"89.870819\" cx=\"77.288872\" id=\"path4475-34-3\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> <ellipse ry=\"2.4112041\" rx=\"2.8022103\" cy=\"90.131493\" cx=\"77.614708\" id=\"path4477-04-4\" style=\"fill:#ffffff;fill-opacity:1;stroke:#000000;stroke-width:5.06500006;stroke-miterlimit:9.25547409;stroke-dasharray:none;stroke-opacity:1\" /> </g></svg>",
            "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?><!-- Created with Inkscape (http://www.inkscape.org/) --><svg xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:cc=\"http://creativecommons.org/ns#\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:svg=\"http://www.w3.org/2000/svg\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:sodipodi=\"http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd\" xmlns:inkscape=\"http://www.inkscape.org/namespaces/inkscape\" version=\"1.0\" width=\"450\" height=\"580\" viewBox=\"0 0 414.772 500.994\" id=\"Layer_2\" xml:space=\"preserve\" inkscape:version=\"0.91 r13725\" sodipodi:docname=\"International_Morse_Code.svg\"><metadata id=\"metadata3375\"><rdf:RDF><cc:Work rdf:about=\"\"><dc:format>image/svg+xml</dc:format><dc:type rdf:resource=\"http://purl.org/dc/dcmitype/StillImage\" /><dc:title></dc:title></cc:Work></rdf:RDF></metadata><sodipodi:namedview pagecolor=\"#ffffff\" bordercolor=\"#666666\" borderopacity=\"1\" objecttolerance=\"10\" gridtolerance=\"10\" guidetolerance=\"10\" inkscape:pageopacity=\"0\" inkscape:pageshadow=\"2\" inkscape:window-width=\"1920\" inkscape:window-height=\"1017\" id=\"namedview3373\" showgrid=\"false\" inkscape:zoom=\"1\" inkscape:cx=\"115.11786\" inkscape:cy=\"248.56716\" inkscape:window-x=\"-8\" inkscape:window-y=\"-8\" inkscape:window-maximized=\"1\" inkscape:current-layer=\"Layer_2\" /><defs id=\"defs3017\" /><g id=\"g2643\"><text x=\"115.249229\" y=\"10.537716\" id=\"text2872\" style=\"font-size:22px;font-family:Special Elite, Sans-Serif;\">How to Interpret</text><text x=\"54.051781\" y=\"38.502422\" style=\"font-size:10px;font-family:Special Elite, Sans-Serif\" id=\"text3411\"><tspan x=\"54.051781\" y=\"38.502422\" id=\"tspan3413\" /><tspan x=\"54.051781\" y=\"38.502422\" id=\"tspan3405\" /><tspan x=\"54.051781\" y=\"38.502422\" id=\"tspan3407\" /><tspan x=\"54.051781\" y=\"38.502422\" id=\"tspan3409\" /></text><text x=\"54.051781\" y=\"38.502422\" style=\"font-size:10px;font-family:Special Elite, Sans-Serif\" id=\"text3401\"><tspan x=\"54.051781\" y=\"38.502422\" id=\"tspan3403\" /></text><text xml:space=\"preserve\" style=\"font-size:15px;font-style:normal;font-weight:normal;line-height:125%;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;font-family:Special Elite, Sans-Serif\" x=\"40.91169\" y=\"55.326767\" id=\"text3464\" sodipodi:linespacing=\"125%\" transform=\"matrix(0.92171556,0,0,0.92171556,0,-16.800511)\"><tspan sodipodi:role=\"line\" id=\"tspan3466\" x=\"40.91169\" y=\"55.326767\">1. A short flash represents a dot.</tspan><tspan sodipodi:role=\"line\" x=\"40.91169\" y=\"75.076767\" id=\"tspan3468\">2. A long flash represents a dash.</tspan><tspan sodipodi:role=\"line\" x=\"40.91169\" y=\"95.826767\" id=\"tspan3470\">3. There is a long gap between letters.</tspan><tspan sodipodi:role=\"line\" x=\"40.91169\" y=\"115.576767\" id=\"tspan3472\">4. There is a very long gap before the word repeats.</tspan></text></g><g transform=\"translate(-3.8164787,0)\" id=\"g3272\"><g transform=\"translate(-18.434315,0)\" id=\"g3132\"><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,202.38592,-57.340438)\" id=\"circle3554\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"285.73181\" y=\"121.45683\" id=\"rect3556\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,220.82023,-57.340438)\" id=\"circle3558\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,202.38592,-38.906127)\" id=\"circle3560\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,220.82023,-38.906126)\" id=\"circle3562\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,239.25454,-38.906126)\" id=\"circle3564\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"304.16614\" y=\"139.89114\" id=\"rect3566\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,202.38592,-20.471816)\" id=\"circle3568\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"267.29752\" y=\"158.32545\" id=\"rect3570\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"304.16614\" y=\"158.32544\" id=\"rect3572\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"248.8632\" y=\"176.75975\" id=\"rect3574\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,239.25454,-2.0375037)\" id=\"circle3576\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,257.68885,-2.0375037)\" id=\"circle3578\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"322.60043\" y=\"176.75977\" id=\"rect3580\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"248.8632\" y=\"195.19408\" id=\"rect3588\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"304.16614\" y=\"195.19408\" id=\"rect3590\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"341.03476\" y=\"195.19408\" id=\"rect3592\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,239.25454,16.396807)\" id=\"circle3594\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"248.8632\" y=\"213.62837\" id=\"rect3596\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"285.73181\" y=\"213.62839\" id=\"rect3598\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,276.12316,34.831118)\" id=\"circle3600\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,294.55748,34.831118)\" id=\"circle3602\" /><g transform=\"translate(-1.8497366,0)\" id=\"g2615\"><text x=\"231.22548\" y=\"130.67398\" id=\"text3604\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">U</text><text x=\"231.74756\" y=\"149.10829\" id=\"text3608\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">V</text><text x=\"229.15523\" y=\"167.31757\" id=\"text3612\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">W</text><text x=\"231.73405\" y=\"185.97691\" id=\"text3616\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">X</text><text x=\"231.76105\" y=\"204.41122\" id=\"text3620\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">Y</text><text x=\"232.27863\" y=\"222.84554\" id=\"text3624\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">Z</text></g></g><g id=\"g3169\"><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,-57.340437)\" id=\"circle2870\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"55.302933\" y=\"121.45683\" id=\"rect3010\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.496285,-38.906126)\" id=\"circle3324\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,45.694276,-38.611276)\" id=\"circle3326\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,64.122679,-38.906126)\" id=\"circle3328\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"158.32544\" id=\"rect3330\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.23125,-20.471815)\" id=\"circle3332\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"92.171555\" y=\"158.32544\" id=\"rect3334\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,82.623628,-20.471815)\" id=\"circle3336\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"176.75977\" id=\"rect3338\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.17162,-2.0375044)\" id=\"circle3340\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,45.694276,-1.8597136)\" id=\"circle3342\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,16.396807)\" id=\"circle3412\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086574,34.831118)\" id=\"circle3414\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,8.8256537,34.831118)\" id=\"circle3416\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"73.737244\" y=\"213.62837\" id=\"rect3420\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,64.128587,34.831118)\" id=\"circle3422\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"232.06268\" id=\"rect3424\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"73.737244\" y=\"232.06268\" id=\"rect3426\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,64.128587,53.265429)\" id=\"circle3428\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,71.69974)\" id=\"circle3458\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,8.8256535,71.69974)\" id=\"circle3460\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.259965,71.69974)\" id=\"circle3462\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,45.694276,71.69974)\" id=\"circle3464\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,90.134051)\" id=\"circle3466\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,8.8256537,90.134051)\" id=\"circle3468\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,108.56836)\" id=\"circle3470\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"55.302933\" y=\"287.36563\" id=\"rect3472\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"92.171555\" y=\"287.36563\" id=\"rect3474\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"129.04018\" y=\"287.36563\" id=\"rect3476\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"305.79993\" id=\"rect3478\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.259965,127.00267)\" id=\"circle3480\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"92.171555\" y=\"305.79996\" id=\"rect3482\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,145.43698)\" id=\"circle3484\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"55.302933\" y=\"324.23425\" id=\"rect3486\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,45.694276,145.43698)\" id=\"circle3488\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,64.128587,145.43698)\" id=\"circle3490\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"342.66858\" id=\"rect3492\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"73.737244\" y=\"342.66858\" id=\"rect3494\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"361.10287\" id=\"rect3496\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.259965,182.30561)\" id=\"circle3498\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"379.5372\" id=\"rect3500\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"73.737244\" y=\"379.5372\" id=\"rect3502\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"110.60587\" y=\"379.5372\" id=\"rect3504\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086576,219.17423)\" id=\"circle3506\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"55.302933\" y=\"397.9715\" id=\"rect3508\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"92.171555\" y=\"397.9715\" id=\"rect3510\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,82.562898,219.17423)\" id=\"circle3512\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"416.40579\" id=\"rect3514\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"73.737244\" y=\"416.40582\" id=\"rect3516\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,64.128587,237.60854)\" id=\"circle3518\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"129.04018\" y=\"416.40582\" id=\"rect3520\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086574,256.04285)\" id=\"circle3522\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"55.302933\" y=\"434.84012\" id=\"rect3524\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,45.694276,256.04285)\" id=\"circle3526\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,27.259965,274.47716)\" id=\"circle3528\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,8.8256537,274.47716)\" id=\"circle3530\" /><circle cx=\"39.4\" cy=\"141.48\" r=\"3.555\" transform=\"matrix(1.296365,0,0,1.296365,-9.6086574,274.47716)\" id=\"circle3532\" /><rect width=\"27.651466\" height=\"9.217145\" x=\"36.868622\" y=\"471.70874\" id=\"rect3534\" /><g id=\"g2573\"><text x=\"17.138149\" y=\"130.67398\" id=\"text3309\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">A</text><text x=\"16.953625\" y=\"149.10829\" id=\"text3344\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">B</text><text x=\"16.535072\" y=\"167.31757\" id=\"text3350\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">C</text><text x=\"16.409058\" y=\"185.97691\" id=\"text3356\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">D</text><text x=\"16.904119\" y=\"204.41122\" id=\"text3360\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">E</text><text x=\"17.322672\" y=\"222.84554\" id=\"text3364\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">F</text><text x=\"16.202032\" y=\"241.05481\" id=\"text3368\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">G</text><text x=\"16.634085\" y=\"259.71414\" id=\"text3372\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">H</text><text x=\"20.693594\" y=\"278.14847\" id=\"text3376\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">I</text><text x=\"19.145401\" y=\"296.58276\" id=\"text3380\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">J</text><text x=\"16.481066\" y=\"315.01709\" id=\"text3384\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">K</text><text x=\"17.813232\" y=\"333.45139\" id=\"text3388\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">L</text><text x=\"15.621459\" y=\"351.88571\" id=\"text3392\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">M</text><text x=\"16.683592\" y=\"370.32001\" id=\"text3396\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">N</text><text x=\"16.085016\" y=\"388.75433\" id=\"text3400\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">O</text><text x=\"16.058014\" y=\"425.62296\" id=\"text3404\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">Q</text><text x=\"16.82761\" y=\"407.18866\" id=\"text3408\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">P</text><text x=\"16.022009\" y=\"444.05728\" id=\"text3536\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">R</text><text x=\"17.205658\" y=\"462.49158\" id=\"text3540\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">S</text><text x=\"17.62421\" y=\"480.9259\" id=\"text3544\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">T</text></g><use transform=\"translate(-18.43431,18.434311)\" id=\"use2703\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /></g><g transform=\"translate(-18.434314,64.295099)\" id=\"g3051\"><use transform=\"translate(211.99458,119.82302)\" id=\"use2707\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(248.8632,119.82301)\" id=\"use2709\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use id=\"use2711\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2709\" /><use transform=\"translate(285.73182,119.82301)\" id=\"use2713\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(322.60045,119.82301)\" id=\"use2715\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(211.99458,119.82302)\" id=\"use2717\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#circle2870\" /><use transform=\"translate(211.99458,138.25733)\" id=\"use2719\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#circle2870\" /><use transform=\"translate(230.42889,138.25733)\" id=\"use2721\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#circle2870\" /><use transform=\"translate(230.42889,138.25733)\" id=\"use2723\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(267.29751,138.25733)\" id=\"use2725\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(304.16613,138.25732)\" id=\"use2727\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#rect3010\" /><use transform=\"translate(211.99458,156.69164)\" id=\"use2779\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#circle2870\" /><use transform=\"translate(18.434309,4.0522843e-6)\" id=\"use2781\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2779\" /><use transform=\"translate(18.434311,0)\" id=\"use2783\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2781\" /><use transform=\"translate(18.434309,18.434308)\" id=\"use2785\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2723\" /><use transform=\"translate(36.868622,9.8155382e-8)\" id=\"use2787\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2785\" /><use transform=\"translate(2.324722e-7,18.434311)\" id=\"use2789\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2779\" /><use transform=\"translate(18.434311,7.8636818e-8)\" id=\"use2791\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2789\" /><use transform=\"translate(18.434311,0)\" id=\"use2793\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2791\" /><use transform=\"translate(18.434311,0)\" id=\"use2795\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2793\" /><use transform=\"translate(18.434313,18.434307)\" id=\"use2797\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2785\" /><use transform=\"translate(-2.3247221e-7,18.434311)\" id=\"use2799\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2789\" /><use transform=\"translate(18.434311,-4.2724257e-8)\" id=\"use2801\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2799\" /><use transform=\"translate(18.434311,0)\" id=\"use2803\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2801\" /><use transform=\"translate(18.434312,0)\" id=\"use2805\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2803\" /><use transform=\"translate(18.434311,0)\" id=\"use2807\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2805\" /><use transform=\"translate(36.868622,36.868622)\" id=\"use2809\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2789\" /><use transform=\"translate(36.868622,36.868622)\" id=\"use2811\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2791\" /><use transform=\"translate(36.868622,36.868622)\" id=\"use2813\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2793\" /><use transform=\"translate(36.868622,36.868622)\" id=\"use2815\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2795\" /><use transform=\"translate(-73.737245,36.868622)\" id=\"use2817\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2797\" /><use id=\"use2819\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2779\" /><use id=\"use2821\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2781\" /><use id=\"use2823\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2783\" /><use id=\"use2825\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2785\" /><use id=\"use2827\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2787\" /><use transform=\"translate(73.737242,73.737248)\" id=\"use2829\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2779\" /><use transform=\"translate(73.737244,73.737244)\" id=\"use2831\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2781\" /><use transform=\"translate(73.737244,73.737244)\" id=\"use2833\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2783\" /><use transform=\"translate(-55.302932,73.73724)\" id=\"use2845\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2825\" /><use transform=\"translate(-55.302931,73.737251)\" id=\"use2847\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2827\" /><use transform=\"translate(36.868622,18.434311)\" id=\"use2849\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2829\" /><use transform=\"translate(36.868622,18.434311)\" id=\"use2851\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2831\" /><use transform=\"translate(36.868622,18.434311)\" id=\"use2855\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2845\" /><use transform=\"translate(36.868622,18.434311)\" id=\"use2857\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2847\" /><use transform=\"translate(-36.868622,3.3648014e-7)\" id=\"use2859\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2855\" /><use transform=\"translate(-18.434316,147.4745)\" id=\"use2861\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2707\" /><use transform=\"translate(-18.434316,147.4745)\" id=\"use2863\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2709\" /><use transform=\"translate(-18.434316,147.4745)\" id=\"use2865\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2711\" /><use transform=\"translate(-18.434316,147.4745)\" id=\"use2867\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2713\" /><use transform=\"translate(-18.434316,147.4745)\" id=\"use2869\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2715\" /><use transform=\"translate(-110.60587,18.434302)\" id=\"use2873\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2869\" /><use transform=\"translate(18.434312,18.434312)\" id=\"use2875\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2851\" /><use transform=\"translate(36.868625,18.434302)\" id=\"use2877\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2861\" /><use transform=\"translate(36.868625,18.434302)\" id=\"use2879\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2863\" /><use transform=\"translate(36.868625,18.434302)\" id=\"use2881\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2865\" /><use transform=\"translate(36.868625,18.434302)\" id=\"use2883\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2867\" /><use transform=\"translate(36.868625,18.434302)\" id=\"use2885\" x=\"0\" y=\"0\" width=\"414.772\" height=\"500.99399\" xlink:href=\"#use2869\" /><g id=\"g3029\"><text x=\"231.75656\" y=\"250.49699\" id=\"text2889\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">1</text><text x=\"231.284\" y=\"268.9313\" id=\"text2893\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">2</text><text x=\"231.09947\" y=\"287.14056\" id=\"text2897\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">3</text><text x=\"231.39651\" y=\"305.79993\" id=\"text2901\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">4</text><text x=\"231.05447\" y=\"324.23422\" id=\"text2905\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">5</text><text x=\"231.14449\" y=\"342.66855\" id=\"text2909\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">6</text><text x=\"231.04997\" y=\"360.87781\" id=\"text2913\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">7</text><text x=\"231.09947\" y=\"379.53714\" id=\"text2917\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">8</text><text x=\"231.09048\" y=\"397.97147\" id=\"text2921\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">9</text><text x=\"231.12648\" y=\"416.40576\" id=\"text2925\" xml:space=\"preserve\" style=\"font-size:18px;font-family:Special Elite, Sans-Serif\">0</text></g></g></g></svg>"
        };

        public static string BlankMaze = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>
<svg
   xmlns:dc=""http://purl.org/dc/elements/1.1/""
   xmlns:cc=""http://creativecommons.org/ns#""
   xmlns:rdf=""http://www.w3.org/1999/02/22-rdf-syntax-ns#""
   xmlns:svg=""http://www.w3.org/2000/svg""
   xmlns=""http://www.w3.org/2000/svg""
   xmlns:sodipodi=""http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd""
   xmlns:inkscape=""http://www.inkscape.org/namespaces/inkscape""
   width=""100%""
   height=""100%""
   viewBox=""0 0 300 300""
   preserveAspectRatio=""xMidYMid meet""
   version=""1.1""
   id=""svg2""
   inkscape:version=""0.91 r13725""
   sodipodi:docname=""mazegrid.svg"">
  <metadata
     id=""metadata182"">
    <rdf:RDF>
      <cc:Work
         rdf:about="""">
        <dc:format>image/svg+xml</dc:format>
        <dc:type
           rdf:resource=""http://purl.org/dc/dcmitype/StillImage"" />
        <dc:title></dc:title>
      </cc:Work>
    </rdf:RDF>
  </metadata>
  <defs
     id=""defs180"" />
  <sodipodi:namedview
     pagecolor=""#ffffff""
     bordercolor=""#666666""
     borderopacity=""1""
     objecttolerance=""10""
     gridtolerance=""10""
     guidetolerance=""10""
     inkscape:pageopacity=""0""
     inkscape:pageshadow=""2""
     inkscape:window-width=""1680""
     inkscape:window-height=""987""
     id=""namedview178""
     showgrid=""false""
     inkscape:zoom=""1.5733333""
     inkscape:cx=""-1.8656304""
     inkscape:cy=""179.97156""
     inkscape:window-x=""1912""
     inkscape:window-y=""-8""
     inkscape:window-maximized=""1""
     inkscape:current-layer=""layer2"" />
  <g
     inkscape:groupmode=""layer""
     id=""layer2""
     inkscape:label=""Walls""
     style=""display:inline"" />
  <g
     inkscape:groupmode=""layer""
     id=""layer1""
     inkscape:label=""Base Maze""
     style=""display:inline"">
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""25""
       r=""3""
       id=""circle4"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""50""
       y1=""0""
       y2=""0""
       id=""line6"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""0""
       y2=""50""
       id=""line8"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""50""
       y2=""100""
       id=""line14"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""125""
       r=""3""
       id=""circle16"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""100""
       y2=""150""
       id=""line18"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""175""
       r=""3""
       id=""circle20"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""150""
       y2=""200""
       id=""line22"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""225""
       r=""3""
       id=""circle24"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""200""
       y2=""250""
       id=""line26"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""275""
       r=""3""
       id=""circle28"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""0""
       y1=""250""
       y2=""300""
       id=""line30"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""0""
       x2=""50""
       y1=""300""
       y2=""300""
       id=""line32"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""25""
       r=""3""
       id=""circle34"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""50""
       x2=""100""
       y1=""0""
       y2=""0""
       id=""line36"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""75""
       r=""3""
       id=""circle38"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""125""
       r=""3""
       id=""circle44"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""175""
       r=""3""
       id=""circle48"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""225""
       r=""3""
       id=""circle54"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""75""
       cy=""275""
       r=""3""
       id=""circle58"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""50""
       x2=""100""
       y1=""300""
       y2=""300""
       id=""line62"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""25""
       r=""3""
       id=""circle64"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""100""
       x2=""150""
       y1=""0""
       y2=""0""
       id=""line66"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""75""
       r=""3""
       id=""circle68"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""125""
       r=""3""
       id=""circle70"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""175""
       r=""3""
       id=""circle74"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""225""
       r=""3""
       id=""circle76"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""125""
       cy=""275""
       r=""3""
       id=""circle80"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""100""
       x2=""150""
       y1=""300""
       y2=""300""
       id=""line84"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""25""
       r=""3""
       id=""circle86"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""150""
       x2=""200""
       y1=""0""
       y2=""0""
       id=""line88"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""75""
       r=""3""
       id=""circle92"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""125""
       r=""3""
       id=""circle96"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""175""
       r=""3""
       id=""circle102"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""225""
       r=""3""
       id=""circle104"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""175""
       cy=""275""
       r=""3""
       id=""circle110"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""150""
       x2=""200""
       y1=""300""
       y2=""300""
       id=""line112"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""25""
       r=""3""
       id=""circle114"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""200""
       x2=""250""
       y1=""0""
       y2=""0""
       id=""line116"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""75""
       r=""3""
       id=""circle118"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""125""
       r=""3""
       id=""circle122"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""175""
       r=""3""
       id=""circle126"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""225""
       r=""3""
       id=""circle132"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""225""
       cy=""275""
       r=""3""
       id=""circle136"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""200""
       x2=""250""
       y1=""300""
       y2=""300""
       id=""line142"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""25""
       r=""3""
       id=""circle144"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""250""
       x2=""300""
       y1=""0""
       y2=""0""
       id=""line146"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""0""
       y2=""50""
       id=""line148"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""75""
       r=""3""
       id=""circle150"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""50""
       y2=""100""
       id=""line154"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""100""
       y2=""150""
       id=""line160"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""175""
       r=""3""
       id=""circle162"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""150""
       y2=""200""
       id=""line164"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""225""
       r=""3""
       id=""circle166"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""200""
       y2=""250""
       id=""line170"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""275""
       r=""3""
       id=""circle172"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""300""
       x2=""300""
       y1=""250""
       y2=""300""
       id=""line174"" />
    <line
       style=""fill:none;stroke:#000000;stroke-width:10;stroke-dasharray:none""
       x1=""250""
       x2=""300""
       y1=""300""
       y2=""300""
       id=""line176"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""25""
       cy=""75""
       r=""3""
       id=""circle10"" />
    <circle
       style=""fill:#808080;stroke:#000000;stroke-width:1""
       cx=""275""
       cy=""125""
       r=""3""
       id=""circle156"" />
  </g>
</svg>
";
    }
}