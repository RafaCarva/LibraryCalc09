using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc09.Entities
{
    /// <summary>
    /// Prove a interface de uma calculadora
    /// </summary>
    public interface IOperations
    {
        /// <summary>
        /// Soma de valores
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultado da soma</returns>
        double OperationAdd(double x, double y);

        /// <summary>
        /// Soma de 3 valores
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        double OperationAdd(double x, double y, double z);

        /// <summary>
        /// Subtração de valores
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultado da subtração</returns>
        double OperationSubtract(double x, double y);

        /// <summary>
        /// Divisão de valores
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultado da divisão</returns>
        double OperationDivide(double x, double y);

        /// <summary>
        /// Multiplicação de valores
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Resultado da multiplicação</returns>
        double OperationMultiply(double x, double y);
    }
}
