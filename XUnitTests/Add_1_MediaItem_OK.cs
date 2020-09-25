using System;
using Xunit;
using MyMediaLibraryModel;
namespace XUnitTests
{
	public class Add_1_MediaItem_OK
	{

		[Fact]
		public void setTitleTest()
		{
			MediaItem meditem = new MediaItem();
			meditem.setTitle("Tetris");
			Assert.Equal("Tetris", meditem.getTitle());
		



		}
		
	}

	
}
