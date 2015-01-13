﻿using System;

namespace SVGKit {

	public enum DOMNodeType : uint {
		_ELEMENT_NODE = 1,
		_ATTRIBUTE_NODE = 2,
		_TEXT_NODE = 3,
		_CDATA_SECTION_NODE = 4,
		_ENTITY_REFERENCE_NODE = 5,
		_ENTITY_NODE = 6,
		_PROCESSING_INSTRUCTION_NODE = 7,
		_COMMENT_NODE = 8,
		_DOCUMENT_NODE = 9,
		_DOCUMENT_TYPE_NODE = 10,
		_DOCUMENT_FRAGMENT_NODE = 11,
		_NOTATION_NODE = 12
	}

	public enum CSSUnitType : uint {
		CSS_INHERIT = 0,
		CSS_PRIMITIVE_VALUE = 1,
		CSS_VALUE_LIST = 2,
		CSS_CUSTOM = 3
	}

	public enum CSSRuleType : uint {
		UNKNOWN_RULE = 0,
		STYLE_RULE = 1,
		CHARSET_RULE = 2,
		IMPORT_RULE = 3,
		MEDIA_RULE = 4,
		FONT_FACE_RULE = 5,
		PAGE_RULE = 6
	}

	public enum SVG_LENGTH_TYPE : uint {
		SVG_LENGTHTYPE_UNKNOWN = 0,
		SVG_LENGTHTYPE_NUMBER = 1,
		SVG_LENGTHTYPE_PERCENTAGE = 2,
		SVG_LENGTHTYPE_EMS = 3,
		SVG_LENGTHTYPE_EXS = 4,
		SVG_LENGTHTYPE_PX = 5,
		SVG_LENGTHTYPE_CM = 6,
		SVG_LENGTHTYPE_MM = 7,
		SVG_LENGTHTYPE_IN = 8,
		SVG_LENGTHTYPE_PT = 9,
		SVG_LENGTHTYPE_PC = 10
	}

	public enum SVG_PRESERVEASPECTRATIO : uint {
		_UNKNOWN = 0,
		_NONE = 1,
		_XMINYMIN = 2,
		_XMIDYMIN = 3,
		_XMAXYMIN = 4,
		_XMINYMID = 5,
		_XMIDYMID = 6,
		_XMAXYMID = 7,
		_XMINYMAX = 8,
		_XMIDYMAX = 9,
		_XMAXYMAX = 10
	}

	public enum SVG_MEETORSLICE : uint {
		_UNKNOWN = 0,
		_MEET = 1,
		_SLICE = 2
	}

	public enum SVGKAngleType : uint {
		SVG_ANGLETYPE_UNKNOWN = 0,
		SVG_ANGLETYPE_UNSPECIFIED = 1,
		SVG_ANGLETYPE_DEG = 2,
		SVG_ANGLETYPE_RAD = 3,
		SVG_ANGLETYPE_GRAD = 4
	}

	public enum SVGKTransformType : uint {
		SVG_TRANSFORM_UNKNOWN = 0,
		SVG_TRANSFORM_MATRIX = 1,
		SVG_TRANSFORM_TRANSLATE = 2,
		SVG_TRANSFORM_SCALE = 3,
		SVG_TRANSFORM_ROTATE = 4,
		SVG_TRANSFORM_SKEWX = 5,
		SVG_TRANSFORM_SKEWY = 6
	}

	public enum SVG_UNIT_TYPE : uint {
		_UNKNOWN = 0,
		_USERSPACEONUSE = 1,
		_OBJECTBOUNDINGBOX = 2
	}

	public enum SVGLengthAdjust : uint {
		Unknown = 0,
		Spacing = 1,
		SpacingAndGlyphs = 2
	}
}
