using DingTalk.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using yanjiuyuanWeb.Models;

namespace yanjiuyuanWeb.Controllers
{

    /// <summary>
    /// 新闻与应用案例管理
    /// </summary>
    [RoutePrefix("NewsAndCases")]
    public class NewsAndCaseManageController : ApiController
    {
        /// <summary>
        /// 新闻与应用案例保存
        /// </summary>
        /// <param name="newsAndCases"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Save")]
        public object Save([FromBody] NewsAndCases newsAndCases)
        {
            try
            {
                EFHelper<NewsAndCases> eFHelper = new EFHelper<NewsAndCases>();
                newsAndCases.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                eFHelper.Add(newsAndCases);
                return new NewErrorModel()
                {
                    error = new Error(0, "保存成功！", "") { },
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


        /// <summary>
        /// 新闻与应用案例读取
        /// </summary>
        /// <param name="bigType">大类</param>
        /// <param name="type">小类</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Read")]
        public object Read(string bigType, string type, int pageIndex, int pageSize)
        {
            try
            {
                EFHelper<NewsAndCases> eFHelper = new EFHelper<NewsAndCases>();
                System.Linq.Expressions.Expression<Func<NewsAndCases, bool>> expression = null;
                expression = n => n.BigType == bigType && n.Type == type;
                List<NewsAndCases> NewsAndCasesListAll = eFHelper.GetListBy(expression);
                List<NewsAndCases> newsAndCases = eFHelper.GetPagedList(pageIndex, pageSize,
                     expression, n => n.Id);
                return new NewErrorModel()
                {
                    count = NewsAndCasesListAll.Count,
                    data = newsAndCases,
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

        /// <summary>
        /// 新闻与应用案例详情读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ReadById")]
        public object ReadById(int id)
        {
            try
            {
                EFHelper<NewsAndCases> eFHelper = new EFHelper<NewsAndCases>();
                NewsAndCases newsAndCases = eFHelper.GetListById(id);
                return new NewErrorModel()
                {
                    data = newsAndCases,
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


        /// <summary>
        /// 访问累加接口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("AddVisitingtime")]
        public object AddVisitingtime(int id)
        {
            try
            {
                EFHelper<NewsAndCases> eFHelper = new EFHelper<NewsAndCases>();
                NewsAndCases newsAndCases = eFHelper.GetListById(id);
                newsAndCases.visitingtime = (newsAndCases.visitingtime==null?0: newsAndCases.visitingtime) + 1;
                eFHelper.Modify(newsAndCases);
                return new NewErrorModel()
                {
                    data = newsAndCases,
                    error = new Error(0, "累加成功！", "") { },
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
