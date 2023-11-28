using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SystemGuard
    {
        public UserType Check(string un,string pwd)
        {
            OperatorService opServ = new OperatorService();
            Operator op = opServ.GetOperator(un);
            OperationLog log = new OperationLog();
            OperationLogService logServ = new OperationLogService();
            UserType ut;
            log.Id = Guid.NewGuid();
            log.ActionDate = DateTime.Now;
            if (op == null)
            {
                log.OperatorId = Guid.Empty;
                log.ActionDesc = "非法登录，无此用户！";
                ut = UserType.NoUser;
            }
            else if (op.Password != pwd)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，密码错误！";
                ut = UserType.PassWordError;
            }
            else if (op.IsLocked)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，登录了被锁定的账户！";
                ut = UserType.Locked;
            }
            else if (op.IsDeleted)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，登录了被删除的用户！";
                ut = UserType.Deleted;
            }
            else if (op.IsAdmin)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "管理员登录";
                LoginUser lu = LoginUser.GetInstance();
                lu.InitMember(op);
                ut = UserType.Admin;
            }
            else
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "合法登录，登录成功！";
                LoginUser lu = LoginUser.GetInstance();
                lu.InitMember(op);
                ut = UserType.ValidUser;
            }
            logServ.Add(log);
            return ut;
        }
    }
    public enum UserType { ValidUser,NoUser,PassWordError,Admin,Locked,Deleted}
}
