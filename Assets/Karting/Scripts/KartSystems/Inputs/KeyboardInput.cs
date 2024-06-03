using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";

        public override InputData GenerateInput() {
            InputData _inputData = new InputData
            {
                VerticalInput = Input.GetAxis("Vertical"),
                Accelerate = Input.GetAxis("Vertical") > 0,
                Brake = Input.GetAxis("Vertical") < 0,
                TurnInput = Input.GetAxis("Horizontal")
            };
            return _inputData;
        }
    }
}
