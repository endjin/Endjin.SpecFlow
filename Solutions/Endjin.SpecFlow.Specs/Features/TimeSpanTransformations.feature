Feature: TimeSpan Transformations


Scenario: Transform 1 day, 1 hour, 1 minute, 1 second
	Given a step contains the TimeSpan argument 1 day, 1 hour, 1 minute, 1 second
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 1    | 1     | 1       | 1       |

Scenario: Transform 5 days, 4 hours, 3 minutes, 2 seconds
	Given a step contains the TimeSpan argument 5 days, 4 hours, 3 minutes, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 4     | 3       | 2       |

Scenario: Transform 5 days, 4 hours, 3 minutes
	Given a step contains the TimeSpan argument 5 days, 4 hours, 3 minutes
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 4     | 3       | 0       |

Scenario: Transform 5 days, 3 minutes, 2 seconds
	Given a step contains the TimeSpan argument 5 days, 3 minutes, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 0     | 3       | 2       |

Scenario: Transform 5 days, 4 hours, 2 seconds
	Given a step contains the TimeSpan argument 5 days, 4 hours, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 4     | 0       | 2       |

Scenario: Transform 4 hours, 3 minutes, 2 seconds
	Given a step contains the TimeSpan argument 4 hours, 3 minutes, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 4     | 3       | 2       |

Scenario: Transform 5 days, 4 hours
	Given a step contains the TimeSpan argument 5 days, 4 hours
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 4     | 0       | 0       |

Scenario: Transform 5 days, 3 minutes
	Given a step contains the TimeSpan argument 5 days, 3 minutes
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 0     | 3       | 0       |

Scenario: Transform 5 days, 2 seconds
	Given a step contains the TimeSpan argument 5 days, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 0     | 0       | 2       |

Scenario: Transform 4 hours, 3 minutes
	Given a step contains the TimeSpan argument 4 hours, 3 minutes
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 4     | 3       | 0       |

Scenario: Transform 4 hours, 2 seconds
	Given a step contains the TimeSpan argument 4 hours, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 4     | 0       | 2       |

Scenario: Transform 3 minutes, 2 seconds
	Given a step contains the TimeSpan argument 3 minutes, 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 0     | 3       | 2       |

Scenario: Transform 5 days
	Given a step contains the TimeSpan argument 5 days
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 5    | 0     | 0       | 0       |

Scenario: Transform 4 hours
	Given a step contains the TimeSpan argument 4 hours
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 4     | 0       | 0       |

Scenario: Transform 3 minutes
	Given a step contains the TimeSpan argument 3 minutes
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 0     | 3       | 0       |

Scenario: Transform 2 seconds
	Given a step contains the TimeSpan argument 2 seconds
	Then the transformed TimeSpan should have
	| Days | Hours | Minutes | Seconds |
	| 0    | 0     | 0       | 2       |