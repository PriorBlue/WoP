var _ = require( 'lodash' );

var wares = {

	names: [
		'clay',
		'brick',
		'trash',
		'crap metal',
		'metal',
		'wood',
		'sawn-off shotgun',
		'bush knife',
		'pick axe',
		'empty fuel can',
		'yellow slime',
		'tin can',
		'atomic cola',
		'broken cell phone',
		'copper',
		'wire',
		'electronic parts',
		'radio',
		'geiger counter',
		'flax',
		'textiles',
		'tent',
		'sneakers',
		'anti radiation medication' ],

	createForPlayer: function () {

		return _.map(this.names, function(wareName){
			return {
				id: wareName.replace( / /g, '' ),
				name:  wareName,
				playerStock: 10

			};
		});

		//return _.zipObject( [ 'id', 'name', 'stock' ], [ this.ids, this.names, _.fill( Array( this.names.length ), 10 ) ] );

	},

	createForMarket: function () {

		return _.map(this.names, function(wareName){
			return {
				id: wareName.replace( ' ', '' ),
				name:  wareName,
				stock: 10,
				priceSell: 8,
				priceBuy: 10

			};
		});

		//return _.zipObject( [ 'id', 'name', 'stock', 'priceSell', 'priceBuy' ], [ this.ids, this.names, _.fill( Array( this.names.length ), 100 ), _.fill( Array( this.names.length ), 8 ), _.fill( Array( this.names.length ), 10 ) ] );

	}

};


module.exports = wares;

