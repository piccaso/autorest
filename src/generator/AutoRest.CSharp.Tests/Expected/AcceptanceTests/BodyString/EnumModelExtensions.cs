// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyString
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for EnumModel.
    /// </summary>
    public static partial class EnumModelExtensions
    {
            /// <summary>
            /// Get enum value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Colors? GetNotExpandable(this IEnumModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).GetNotExpandableAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get enum value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Colors?> GetNotExpandableAsync(this IEnumModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNotExpandableWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: 'red color', 'green-color', 'blue_color'
            /// </param>
            public static void PutNotExpandable(this IEnumModel operations, Colors stringBody)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).PutNotExpandableAsync(stringBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: 'red color', 'green-color', 'blue_color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutNotExpandableAsync(this IEnumModel operations, Colors stringBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutNotExpandableWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get enum value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Colors? GetReferenced(this IEnumModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).GetReferencedAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get enum value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Colors?> GetReferencedAsync(this IEnumModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetReferencedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumStringBody'>
            /// Possible values include: 'red color', 'green-color', 'blue_color'
            /// </param>
            public static void PutReferenced(this IEnumModel operations, Colors enumStringBody)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).PutReferencedAsync(enumStringBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends value 'red color' from enumeration of 'red color', 'green-color',
            /// 'blue_color'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumStringBody'>
            /// Possible values include: 'red color', 'green-color', 'blue_color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutReferencedAsync(this IEnumModel operations, Colors enumStringBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutReferencedWithHttpMessagesAsync(enumStringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get value 'green-color' from the constant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static RefColorConstant GetReferencedConstant(this IEnumModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).GetReferencedConstantAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get value 'green-color' from the constant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<RefColorConstant> GetReferencedConstantAsync(this IEnumModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetReferencedConstantWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends value 'green-color' from a constant
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field1'>
            /// Sample string.
            /// </param>
            public static void PutReferencedConstant(this IEnumModel operations, string field1 = default(string))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEnumModel)s).PutReferencedConstantAsync(field1), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends value 'green-color' from a constant
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field1'>
            /// Sample string.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutReferencedConstantAsync(this IEnumModel operations, string field1 = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutReferencedConstantWithHttpMessagesAsync(field1, null, cancellationToken).ConfigureAwait(false);
            }

    }
}