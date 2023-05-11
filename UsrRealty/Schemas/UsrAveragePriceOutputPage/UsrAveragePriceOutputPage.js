define("UsrAveragePriceOutputPage", [], function() {
	return {
		entitySchemaName: "",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Button-b24aee4ea7a4422fbed7b35a267ec73a",
				"values": {
					"itemType": 5,
					"id": "8947703d-d009-4401-9d4b-823e15b6c31a",
					"style": "green",
					"tag": "Button1",
					"caption": {
						"bindTo": "Resources.Strings.Button1ButtonCaption"
					},
					"click": {
						"bindTo": "onSaveButtonClick"
					},
					"enabled": true
				},
				"parentName": "ProcessActionButtons",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "FLOATcc38bf6e-8dd9-46e4-a0e5-6df016f2552d",
				"values": {
					"layout": {
						"colSpan": 7,
						"rowSpan": 1,
						"column": 6,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrAveragePriceUSD",
					"enabled": false
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "STRING0dba9e19-2adc-40d4-a86d-e5efe4fcd37e",
				"values": {
					"layout": {
						"colSpan": 14,
						"rowSpan": 4,
						"column": 0,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "UsrString1",
					"enabled": false,
					"contentType": 0
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_DIFF*/
	};
});
