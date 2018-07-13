using System;
using JetBrains.Annotations;

namespace Bind.XML.Signatures.Enumerations
{
    /// <summary>
    /// Represents a token signature inside an enumeration.
    /// </summary>
    public class TokenSignature
    {
        /// <summary>
        /// Gets the name of the token.
        /// </summary>
        [NotNull]
        public string Name { get; }

        /// <summary>
        /// Gets the value of the token. Typically, this is represented as a hexadecimal string.
        /// </summary>
        public long Value { get; }

        /// <summary>
        /// Gets the version the token was introduced in.
        /// </summary>
        [NotNull]
        public Version IntroducedIn { get; internal set; }

        /// <summary>
        /// Gets the version that the token was deprecated in.
        /// </summary>
        [CanBeNull]
        public Version DeprecatedIn { get; }

        /// <summary>
        /// Gets arbitrary remarks about the token.
        /// </summary>
        [CanBeNull]
        public string Remarks { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenSignature"/> class.
        /// </summary>
        /// <param name="name">The name of the token.</param>
        /// <param name="value">The value of the token.</param>
        /// <param name="introducedIn">The version the token was introduced in.</param>
        /// <param name="deprecatedIn">The version the token was deprecated in, if any.</param>
        /// <param name="remarks">Any remarks about the token. Optional.</param>
        public TokenSignature
        (
            [NotNull] string name,
            long value,
            [NotNull] Version introducedIn,
            [CanBeNull] Version deprecatedIn = null,
            [CanBeNull] string remarks = null
        )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value;
            IntroducedIn = introducedIn ?? throw new ArgumentNullException(nameof(introducedIn));
            DeprecatedIn = deprecatedIn;
            Remarks = remarks;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} = 0x{Value:X}";
        }
    }
}
