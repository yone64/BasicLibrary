﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Core
{
    public class PropertyCache<TObj>
    {
        private static ConcurrentDictionary<string, Delegate> _getterCache = new ConcurrentDictionary<string, Delegate>();
        private static ConcurrentDictionary<string, Delegate> _setterCache = new ConcurrentDictionary<string, Delegate>();

        /// <summary>
        /// PropertyのGetterをFuncとして取得します。
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Func<TObj, TProp> GetGetter<TProp>(Expression<Func<TObj, TProp>> exp)
            => GetGetter<TProp>(GetPropertName(exp));

        /// <summary>
        /// PropertyのGetterをFuncとして取得します。
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static Func<TObj, TProp> GetGetter<TProp>(string propertyName)
        {
            return (Func<TObj, TProp>)_getterCache.GetOrAdd(propertyName,
                s => typeof(TObj).GetTypeInfo().GetDeclaredProperty(s).GetMethod.CreateDelegate(typeof(Func<TObj, TProp>)));
        }


        /// <summary>
        /// PropertyのSetterをActionとして取得します。
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Action<TObj, TProp> SetGetter<TProp>(Expression<Func<TObj, TProp>> exp)
            => SetGetter<TProp>(GetPropertName(exp));

        public static Action<TObj, TProp> SetGetter<TProp>(string propertyName)
        {
            return (Action<TObj, TProp>)_getterCache.GetOrAdd(propertyName,
                s => typeof(TObj).GetTypeInfo().GetDeclaredProperty(s).SetMethod.CreateDelegate(typeof(Action<TObj, TProp>)));
        }


        private static string GetPropertName<TProp>(Expression<Func<TObj, TProp>> exp) 
            => ((MemberExpression)exp.Body).Member.Name;
    }
}