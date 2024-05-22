/** @type {import('ts-jest').JestConfigWithTsJest} */
module.exports = {
  preset: 'ts-jest',
  testEnvironment: 'node',
  rootDir: './',
  coverageDirectory: "<rootDir>/coverage",
  collectCoverageFrom: [
      "<rootDir>/src/**/*.ts"
  ],
  coverageReporters: [
      "json",
      "html"
  ],
  testPathIgnorePatterns: [
      "<rootDir>/node_modules"
  ],
  testMatch: [
      "<rootDir>/test/**/*.ts"
  ]
};