using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Sorter.Core
{
    public static class ExpressionHelpers
    {
        public static T GetValue<T>(this Expression<Func<T>> expression) => expression.Compile().Invoke();

        public static void SetValue<T>(this Expression<Func<T>> lambda, T value)
        {
            var expression = lambda.Body as MemberExpression;

            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            propertyInfo.SetValue(target, value);
        }
    }
}
