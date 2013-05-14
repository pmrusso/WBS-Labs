function aniSprite (columnSize, rowSize, colFrameStart, rowFrameStart, totalFrames, framesPerSecond)
{
	var index : int = Time.time * framesPerSecond;
	index = index % totalFrames;
	
	var size = Vector2 ( 1.0 / columnSize, 1.0 / rowSize);
	
	var u = index % columnSize;
	var v = index / columnSize;
	
	var offset = Vector2 ((u + colFrameStart) * size.x,(1.0 - size.y) - (v + rowFrameStart) * size.y);
	
	renderer.material.mainTextureOffset = offset;
	renderer.material.mainTextureScale  = size;
	
	renderer.material.SetTextureOffset ("_BumpMap", offset);
	renderer.material.SetTextureScale  ("_BumpMap", size);
}
