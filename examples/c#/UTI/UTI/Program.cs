/* This is an exampel of how to use UTI interface with c# code. 
 * The goal of this code is to make it easy to READ and UNDERSTAND. 
 * This is NOT made to be OPTIMIZED. For that i would look at the engines included in the official tiktaktoe project.
 *  - Laurent Aerens (aka anakwaboe4) 
 */
string pos = "FirstPart SecondPart";
var (position, player) = (pos.Split(' ')[0], pos.Split(' ')[1]);
Console.WriteLine(player);
Console.WriteLine(position);