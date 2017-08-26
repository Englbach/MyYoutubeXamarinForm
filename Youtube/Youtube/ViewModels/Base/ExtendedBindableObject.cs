using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Youtube.ViewModels.Base
{
    public abstract class ExtendedBindableObject : BindableObject
    {
        public void RaiseProtertyChanged<T>(Expression<Func<T>> propterty)
        {
            var name = GetMemberInfo(propterty).Name;
            OnPropertyChanged(name);
        }


        private MemberInfo GetMemberInfo(Expression expression)
        {
            MemberExpression operand;
            LambdaExpression lambdaExpression = (LambdaExpression)expression;
            if (lambdaExpression.Body as UnaryExpression != null)
            {
                UnaryExpression body = (UnaryExpression)lambdaExpression.Body;
                operand = (MemberExpression)body.Operand;
            }
            else
            {
                operand = (MemberExpression)lambdaExpression.Body;
            }
            return operand.Member;
        }
    }
}
