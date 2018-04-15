﻿#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2018 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using HeuristicLab.Common;

namespace HeuristicLab.Problems.Instances.DataAnalysis {
  public class SalutowiczFunctionOneDimensional : ArtificialRegressionDataDescriptor {

    public override string Name { get { return "Vladislavleva-2 F2(X) = exp(-X) * X³ * cos(X) * sin(X) * (cos(X)sin(X)² - 1)"; } }
    public override string Description {
      get {
        return "Paper: Order of Nonlinearity as a Complexity Measure for Models Generated by Symbolic Regression via Pareto Genetic Programming " + Environment.NewLine
        + "Authors: Ekaterina J. Vladislavleva, Member, IEEE, Guido F. Smits, Member, IEEE, and Dick den Hertog" + Environment.NewLine
        + "Function: F2(X) = exp(-X) * X³ * cos(X) * sin(X) * (cos(X)sin(X)² - 1)" + Environment.NewLine
        + "Training Data: 100 points X = (0.05:0.1:10)" + Environment.NewLine
        + "Test Data: 221 points X = (-0.5:0.05:10.5)" + Environment.NewLine
        + "Function Set: +, -, *, /, square, e^x, e^-x, sin(x), cos(x), x^eps, x + eps, x + eps";
      }
    }
    protected override string TargetVariable { get { return "Y"; } }
    protected override string[] VariableNames { get { return new string[] { "X", "Y" }; } }
    protected override string[] AllowedInputVariables { get { return new string[] { "X" }; } }
    protected override int TrainingPartitionStart { get { return 0; } }
    protected override int TrainingPartitionEnd { get { return 100; } }
    protected override int TestPartitionStart { get { return 100; } }
    protected override int TestPartitionEnd { get { return 321; } }

    protected override List<List<double>> GenerateValues() {
      List<List<double>> data = new List<List<double>>();
      data.Add(SequenceGenerator.GenerateSteps(0.05m, 10, 0.1m).Select(v => (double)v).ToList());
      data[0].AddRange(SequenceGenerator.GenerateSteps(-0.5m, 10.5m, 0.05m).Select(v => (double)v));

      double x;
      List<double> results = new List<double>();
      for (int i = 0; i < data[0].Count; i++) {
        x = data[0][i];
        results.Add(Math.Exp(-x) * Math.Pow(x, 3) * Math.Cos(x) * Math.Sin(x) * (Math.Cos(x) * Math.Pow(Math.Sin(x), 2) - 1));
      }
      data.Add(results);

      return data;
    }
  }
}
