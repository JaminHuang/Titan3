using System.Collections.Generic;
using Titan.Entities;

namespace Titan.Service
{
	public class UserInfoService
	{
		/// <summary>
		/// 添加
		/// </summary>
		/// <param name="userInfo">添加的对象</param>
		/// <returns></returns>
		public UserInfo Add(UserInfo userInfo)
		{
			userInfo.Insert();
			return userInfo;
		}

		/// <summary>
		/// 修改
		/// </summary>
		/// <param name="userInfo"></param>
		/// <returns></returns>
		public UserInfo Update(UserInfo userInfo)
		{
			userInfo.Update();//默认修改所有
			//userInfo.Update(UserAccreProperties.UserId);//修改指定字段
			return userInfo;
		}

		/// <summary>
		/// 获取指定对象[主键]
		/// </summary>
		/// <param name="userId">主键</param>
		/// <returns></returns>
		public UserInfo Get(string userId)
		{
			var userInfo = new UserInfo(userId);
			userInfo.Select();//Ture为成功，false为失败
			return userInfo;
		}

		/// <summary>
		/// 查询获取列表
		/// </summary>
		/// <returns></returns>
		public List<UserInfo> List()
		{
			var query = new QueryExpression();
			query.Selects.Add(UserInfoProperties.ALL);//查询字段
			//query.Wheres.Add(UserInfoProperties.UserName.Equal("123"));//查询条件
			var uList = new UserInfos();
			uList.Select(query);
			return uList.Items;
		}

		/// <summary>
		/// 删除指定对象[主键]
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public bool Delete(string userId)
		{
			var userInfo = new UserInfo(userId);
			return userInfo.Delete() > 0;
		}
	}
}
