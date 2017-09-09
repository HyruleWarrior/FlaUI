using System.Linq;
using FlaUI.Core.Definitions;
using FlaUI.Core.AutomationElements.PatternElements;
using FlaUI.Core.Patterns;

namespace FlaUI.Core.AutomationElements
{
    public class Button : InvokeAutomationElement
    {
        private readonly ToggleAutomationElement _toggleAutomationElement;

        public Button(BasicAutomationElementBase basicAutomationElement) : base(basicAutomationElement)
        {
            _toggleAutomationElement = new ToggleAutomationElement(basicAutomationElement);
        }

        /// <summary>
        /// Gets the current ToggleState 
        /// </summary>
        public ToggleState ToggleState => _toggleAutomationElement.State;

        /// <summary>
        /// Gets the ITogglePattern from the ToggleAutomationElement
        /// </summary>
        private ITogglePattern TogglePattern
        {
            get
            {
                ITogglePattern pattern;
                _toggleAutomationElement.Patterns.Toggle.TryGetPattern(out pattern);
                return pattern;
            }
        }

        /// <summary>
        /// Toggles the button state
        /// </summary>
        public void Toggle()
        {
            TogglePattern?.Toggle();
        }
    }
}
