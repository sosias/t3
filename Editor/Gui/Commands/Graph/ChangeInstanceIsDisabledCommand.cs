﻿using System;
using System.Linq;
using T3.Core.Logging;

namespace T3.Editor.Gui.Commands.Graph
{
    public class ChangeInstanceIsDisabledCommand : ICommand
    {
        public string Name => "Disable/Enable";
        public bool IsUndoable => true;

        public ChangeInstanceIsDisabledCommand(SymbolChildUi symbolChildUi, bool setDisabledTo)
        {
            _inputParentSymbolId = symbolChildUi.SymbolChild.Parent.Id;
            _childId = symbolChildUi.Id;
            _originalState = symbolChildUi.IsDisabled;
            _newState = setDisabledTo;
        }

        public void Undo()
        {
            AssignValue(_originalState);
        }

        public void Do()
        {
            AssignValue(_newState);
        }

        private void AssignValue(bool shouldBeDisabled)
        {
            if (!SymbolUiRegistry.Entries.TryGetValue(_inputParentSymbolId, out var symbolUi))
                return;
            
            var childUi = symbolUi.ChildUis.SingleOrDefault(c => c.Id == _childId);
            if (childUi == null)
            {
                Log.Assert("Failed to find childUi");
                return;
            }

            childUi.IsDisabled = shouldBeDisabled;
        }

        private readonly bool _newState;
        private readonly bool _originalState;
        private readonly Guid _inputParentSymbolId;
        private readonly Guid _childId;
    }
}