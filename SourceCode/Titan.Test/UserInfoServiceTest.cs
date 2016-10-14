using System;
using System.Reflection;
using Titan.Entities;
using Titan.Service;
using Xunit;

namespace Titan.Test
{
	public class UserInfoServiceTest
	{
		private UserInfoService userInfoService = new UserInfoService();

		/// <summary>
		/// 添加测试
		/// </summary>
		[Fact]
		public void Add_Test()
		{
			var userInfo = new UserInfo{ UserId = "cs123", UserName = "测试123"};
			var res = userInfoService.Add(userInfo);

			Assert.Equal("测试123", res.UserName);
		}

		/// <summary>
		/// 获取测试
		/// </summary>
		[Fact]
		public void Get_Test()
		{
			var res = userInfoService.Get("cs123");

			Assert.Equal("测试123", res.UserName);
		}

		/// <summary>
		/// 修改测试
		/// </summary>
		[Fact]
		public void Update_Test()
		{
			var userInfo = new UserInfo { UserId = "cs123", UserName = "测试123(改)" };
			var res = userInfoService.Update(userInfo);

			Assert.Equal(userInfo.UserName, res.UserName);
		}

		/// <summary>
		/// 获取列表测试
		/// </summary>
		[Fact]
		public void List_Test()
		{
			var res = userInfoService.List();

			Assert.Equal(true, res.Count > 0);
		}

		/// <summary>
		/// 删除测试
		/// </summary>
		[Fact]
		public void Del_Test()
		{
			var res = userInfoService.Delete("cs123");

			Assert.Equal(true, res);
		}
	}
}
