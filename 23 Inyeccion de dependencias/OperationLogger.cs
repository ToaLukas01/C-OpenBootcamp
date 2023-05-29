using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class OperationLogger
    {
        private readonly ITransientOperation _transientOperation;
        private readonly IScopeOperation _scopeOperation;
        private readonly ISingueltonOperation _singueltonOperation;

        public OperationLogger(ITransientOperation transientOperation,
            IScopeOperation scopeOperation,
            ISingueltonOperation singueltonOperation) => 
            (_transientOperation, _scopeOperation, _singueltonOperation) =
            (transientOperation, scopeOperation, singueltonOperation);
        
        public void LogOPerations(string scope)
        {
            LogOPeration(_transientOperation, scope, "Desde TransientOperation");
            LogOPeration(_scopeOperation, scope, "Desde ScopeOperation");
            LogOPeration(_singueltonOperation, scope, "Desde SingueltonOperation");
        }

        private static void LogOperation<T>(T operation, string scope, string msg)
        where T : IOperation => 
            Console.WriteLine($"{scope}: {typeof(T).Name} [{operation.OperationID} - {msg}]");



    }
