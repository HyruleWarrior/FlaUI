using System.Linq;
using FlaUI.Core.Definitions;
using FlaUI.Core.AutomationElements.PatternElements;
using FlaUI.Core.Patterns;
using FlaUI.Core.Exceptions;

namespace FlaUI.Core.AutomationElements
{
    public class ToggleButton : Button
    {
        private readonly ToggleAutomationElement _toggleAutomationElement;

        public ToggleButton(BasicAutomationElementBase basicAutomationElement) : base(basicAutomationElement)
        {
            _toggleAutomationElement = new ToggleAutomationElement(basicAutomationElement);
            if (!_toggleAutomationElement.Patterns.Toggle.IsSupported)
            {
                throw new PatternNotSupportedException();
            }
        }

        /// <summary>
        /// Gets the current ToggleState 
        /// </summary>
        public ToggleState ToggleState => _toggleAutomationElement.State;

        /// <summary>
        /// Gets the ITogglePattern from the ToggleAutomationElement
        /// </summary>
        private ITogglePattern TogglePattern => _toggleAutomationElement.Patterns.Toggle.Pattern;

        /// <summary>
        /// Toggles the button state
        /// </summary>
        public void Toggle()
        {
            TogglePattern.Toggle();
        }
    }
}
