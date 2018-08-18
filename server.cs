$PI = mAtan(1,0) * 2;

function serverCmdFace(%cl, %direction)
{
	if(%direction $= "north" || %direction $= "")
		%cl.player.SetTransform(%cl.player.GetPosition() SPC "0 0 1 0");
	else if(%direction $= "east")
		%cl.player.SetTransform(%cl.player.GetPosition() SPC "0 0 1" SPC $PI/2);
	else if(%direction $= "south")
		%cl.player.SetTransform(%cl.player.GetPosition() SPC "0 0 1" SPC $PI);
	else if(%direction $= "west")
		%cl.player.SetTransform(%cl.player.GetPosition() SPC "0 0 1" SPC $PI + $PI/2);
}