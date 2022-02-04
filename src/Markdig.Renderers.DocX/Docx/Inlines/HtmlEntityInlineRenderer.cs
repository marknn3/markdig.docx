// Copyright (c) Nicolas Musset. All rights reserved.
// This file is licensed under the MIT license.
// See the LICENSE.md file in the project root for more information.

using Markdig.Syntax.Inlines;

namespace Markdig.Renderers.Docx.Inlines
{
    /// <summary>
    /// A XAML renderer for a <see cref="HtmlEntityInline"/>.
    /// </summary>
    /// <seealso cref="XamlObjectRenderer{TObject}" />
    public class HtmlEntityInlineRenderer : DocxObjectRenderer<HtmlEntityInline>
    {
        protected override void Write(DocxRenderer renderer, HtmlEntityInline obj)
        {
            if (renderer == null) throw new ArgumentNullException(nameof(renderer));
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            renderer.WriteRunText(obj.Transcoded.ToString());
        }
    }
}
