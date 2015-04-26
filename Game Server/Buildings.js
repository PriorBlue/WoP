var _ = require( 'lodash' );

var buildings = {

	names: [
		'claypit',
		'brickyard',
		'waste dump',
		'scrapyard',
		'foundry'
	],

	generateList: function () {

		return _.map( this.names, function ( buildingName ) {
			return {
				id                : buildingName.replace( / /g, '' ),
				owner             : null,
				name              : buildingName,
				positionX         : 0,
				positionY         : 0,
				input             : [], output: [],
				cycleDuration     : 20,
				active            : false,
				constructionCost  : 1000,
				constructionInput : [ { 'crapmetal': 10 } ],
				constructionOutput: [ { 'metal': 5 } ]

			};
		} );
	},

	randomList: function ( n ) {

		n = n > this.names.length ? this.names.length : n;

		var list = _.clone( this.names );
		list = _.shuffle(list);
		var responseList = [];

		for (var i = 0; i < n; i++) {
			responseList.push( list[ i ] );
		}

		return responseList;
	}
};


module.exports = buildings;

/*
 private string name = "### undefined ###";
 private int outputAmount01, inputAmount01, inputAmount02, inputAmount03 = 0;
 private Ware outputWare01, inputWare01, inputWare02, inputWare03;

 private int cycleDuration = 20;
 private bool active = true;
 private Player owner;

 private int constructionCost = 2000;
 private int buildAmount01, buildAmount01, buildAmount02, buildAmount03 = 0;
 private Ware buildWare01, buildWare01, buildWare02, buildWare03;

 private int positionX, positionY = 10;

 public string Name { get { return name; } }
 */