// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using TouchScript.InputSources;

namespace TouchScript.Pointers
{
    /// <summary>
    /// A pointer of type <see cref="Pointer.PointerType.Pen"/>.
    /// </summary>
    public class PenPointer : Pointer
    {
        #region Public consts

        /// <summary>
        /// Default pressure value when device doesn't provide it.
        /// </summary>
        public const float DEFAULT_PRESSURE = 0.5f;

        /// <summary>
        /// Default rotation value when device doesn't provide it.
        /// </summary>
        public const float DEFAULT_ROTATION = 0f;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the touch's rotation.
        /// </summary>
        /// <value> Rotation in radians. </value>
        public float Rotation { get; set; }

        /// <summary>
        /// Gets or sets the touch's pressure.
        /// </summary>
        /// <value> Pressure in range [0, 1]. </value>
        public float Pressure { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PenPointer"/> class.
        /// </summary>
        public PenPointer(IInputSource input) : base(input)
        {
            Type = PointerType.Pen;
        }

        #endregion

        #region Internal functions

        /// <inheritdoc />
        internal override void INTERNAL_Reset()
        {
            base.INTERNAL_Reset();

            Rotation = DEFAULT_ROTATION;
            Pressure = DEFAULT_PRESSURE;
        }

        #endregion
    }
}