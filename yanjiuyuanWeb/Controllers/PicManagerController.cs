using DingTalk.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using yanjiuyuanWeb.Models;

namespace DingTalk.Controllers
{
    /// <summary>
    /// 图片数据管理
    /// </summary>
    [RoutePrefix("PicManage")]
    public class PicManageController : ApiController
    {
        /// <summary>
        /// 图片数据分页
        /// </summary>
        /// <param name="type">所属类型(必填)</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        [Route("Read")]
        [HttpGet]
        public object Read(string type, int pageIndex, int pageSize)
        {
            try
            {
                EFHelper<PicInfo> eFHelper = new EFHelper<PicInfo>();
                System.Linq.Expressions.Expression<Func<PicInfo, bool>> expression = null;
                expression = n => n.Type == type;
                List<PicInfo> PicInfoListAll = eFHelper.GetListBy(expression);
                List<PicInfo> PicInfoList = eFHelper.GetPagedList(pageIndex, pageSize,
                     expression, n => n.Id);
                return new NewErrorModel()
                {
                    count = PicInfoListAll.Count,
                    data = PicInfoList,
                    error = new Error(0, "读取成功！", "") { },
                };
            }
            catch (Exception ex)
            {
                return new NewErrorModel()
                {
                    error = new Error(1, ex.Message, "") { },
                };
            }
        }
    }
}
