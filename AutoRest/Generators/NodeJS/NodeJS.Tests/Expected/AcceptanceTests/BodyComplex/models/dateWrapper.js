'use strict';

var util = require('util');

var models = require('./index');

/**
 * @class
 * Initializes a new instance of the DateWrapper class.
 * @constructor
 */
function DateWrapper() { }

/**
 * Validate the payload against the DateWrapper schema
 *
 * @param {JSON} payload
 *
 */
DateWrapper.prototype.validate = function (payload) {
  if (!payload) {
    throw new Error('DateWrapper cannot be null.');
  }
  if (payload['field'] !== null && payload['field'] !== undefined && 
      !(payload['field'] instanceof Date || 
        (typeof payload['field'] === 'string' && !isNaN(Date.parse(payload['field']))))) {
    throw new Error('payload[\'field\'] must be of type date.');
  }

  if (payload['leap'] !== null && payload['leap'] !== undefined && 
      !(payload['leap'] instanceof Date || 
        (typeof payload['leap'] === 'string' && !isNaN(Date.parse(payload['leap']))))) {
    throw new Error('payload[\'leap\'] must be of type date.');
  }
};

/**
 * Deserialize the instance to DateWrapper schema
 *
 * @param {JSON} instance
 *
 */
DateWrapper.prototype.deserialize = function (instance) {
  if (instance) {
    if (instance.field !== null && instance.field !== undefined) {
      instance.field = new Date(instance.field);
    }

    if (instance.leap !== null && instance.leap !== undefined) {
      instance.leap = new Date(instance.leap);
    }
  }
  return instance;
};

module.exports = new DateWrapper();