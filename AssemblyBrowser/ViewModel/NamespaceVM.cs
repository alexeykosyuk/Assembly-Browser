﻿using AssemblyAnalyzer.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowser.ViewModel
{
    public class NamespaceVM
    {
        private readonly NamespaceDeclaration _namespaceDeclaration;

        public string StringPresentation
        {
            get => _namespaceDeclaration.Name;
            private set { }
        }

        public IEnumerable<TypeVM> Types
        {
            get
            {
                foreach (TypeDeclaration type in _namespaceDeclaration.TypeDeclarations)
                    yield return new TypeVM(type);
            }
            private set { }
        }

        public NamespaceVM(NamespaceDeclaration namespaceDeclaration)
        {
            _namespaceDeclaration = namespaceDeclaration;
        }
    }
}
