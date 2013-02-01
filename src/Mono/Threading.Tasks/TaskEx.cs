using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Threading.Tasks
{
	public static class TaskEx
	{
		public static Task Run(Action action)
		{
			return Task.Run(action);
		}

		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return Task.Run(action, cancellationToken);
		}

		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return Task.Run<TResult>(function);
		}

		public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Task.Run<TResult>(function, cancellationToken);
		}

		public static Task Run(Func<Task> function)
		{
			return Task.Run(function);
		}

		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			return Task.Run(function, cancellationToken);
		}

		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return Task.Run<TResult>(function);
		}

		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return Task.Run<TResult>(function, cancellationToken);
		}


        public static Task WhenAll(params Task[] tasks)
        {
            return TaskEx.WhenAll((IEnumerable<Task>)tasks);
        }

        public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
        {
            return TaskEx.WhenAll<TResult>((IEnumerable<Task<TResult>>)tasks);
        }

      
        public static Task WhenAll(IEnumerable<Task> tasks)
        {
            return Task.WhenAll(tasks);
        }

        public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
        {
            return Task.WhenAll<TResult>(tasks);
        }
   
        public static Task<Task> WhenAny(params Task[] tasks)
        {
            return TaskEx.WhenAny((IEnumerable<Task>)tasks);
        }

        public static Task<Task> WhenAny(IEnumerable<Task> tasks)
        {
            return Task.WhenAny(tasks);
        }

        public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
        {
            return TaskEx.WhenAny<TResult>((IEnumerable<Task<TResult>>)tasks);
        }

        public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
        {
            return Task.WhenAny<TResult>(tasks);
        }

	}
}